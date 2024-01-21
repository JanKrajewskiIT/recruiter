using FluentValidation;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Questions.Api.Handlers;

internal class ValidationExceptionHandler(
    IProblemDetailsService problemDetailsService,
    ILogger<ValidationExceptionHandler> logger )
    : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync( HttpContext httpContext, Exception exception, CancellationToken cancellationToken )
    {
        if (exception is not ValidationException validationException)
        {
            return false;
        }

        logger.LogError( exception, "Validation exception occurred: {Message}", exception.Message );

        var validationErrors = validationException.Errors
            .GroupBy( e => e.PropertyName, e => e.ErrorMessage )
            .ToDictionary( e => e.Key, e => e.ToArray() );

        var problemDetails = new ValidationProblemDetails
        {
            Title = "Validation Error Occurred",
            Status = StatusCodes.Status422UnprocessableEntity,
            Instance = httpContext.Request.Path,
            Detail = validationException.Message,
            Errors = validationErrors,
        };

        httpContext.Response.StatusCode = problemDetails.Status.Value;

        await problemDetailsService.TryWriteAsync( new ProblemDetailsContext
        {
            HttpContext = httpContext,
            ProblemDetails = problemDetails,
            Exception = validationException
        } );

        return true;
    }
}
