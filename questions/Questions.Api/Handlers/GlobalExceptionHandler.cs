using FluentValidation;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Questions.Api.Handlers;

internal class GlobalExceptionHandler(
    IHostEnvironment env,
    IProblemDetailsService problemDetailsService,
    ILogger<GlobalExceptionHandler> logger )
    : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync( HttpContext httpContext, Exception exception, CancellationToken cancellationToken )
    {
        if (exception is ValidationException)
        {
            return false;
        }

        logger.LogError( exception, "Exception occurred: {Message}", exception.Message );

        var problemDetails = new ProblemDetails
        {
            Title = "An Error Occurred",
            Status = GetStatusCode( exception ),
            Instance = httpContext.Request.Path,
            Detail = exception.Message,
        };

        if (env.IsDevelopment())
        {
            problemDetails.Extensions.Add( "stackTrace", exception.StackTrace );
            problemDetails.Extensions.Add( "innerMessage", exception.InnerException?.Message );
        }

        httpContext.Response.StatusCode = problemDetails.Status.Value;

        await problemDetailsService.TryWriteAsync( new ProblemDetailsContext
        {
            HttpContext = httpContext,
            ProblemDetails = problemDetails,
            Exception = exception
        } );

        return true;
    }

    private static int GetStatusCode( Exception exception ) => exception switch
    {
        ArgumentNullException _ => StatusCodes.Status422UnprocessableEntity,
        TimeoutException _ => StatusCodes.Status408RequestTimeout,
        NotImplementedException _ => StatusCodes.Status501NotImplemented,
        HttpRequestException ex when ex.StatusCode is HttpStatusCode.Unauthorized or HttpStatusCode.Forbidden => (int)ex.StatusCode,
        _ => StatusCodes.Status400BadRequest
    };
}
