using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using static Microsoft.AspNetCore.Http.StatusCodes;

namespace Questions.Api.Middlewares;

internal class ExceptionMiddleware(
    RequestDelegate request,
    IHostEnvironment env,
    IProblemDetailsService problemDetailsService,
    ILogger<ExceptionMiddleware> logger)
{
    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await request(context);
        }
        catch (ValidationException exception)
        {
            await WriteResponseAsync(context, exception);
        }
        catch (Exception exception)
        {
            await WriteResponseAsync(context, exception);
        }
    }

    private async Task WriteResponseAsync(HttpContext context, ValidationException exception)
    {
        logger.LogWarning( "Validation error occured {@exception}", exception );

        const int statusCode = Status422UnprocessableEntity;
        context.Response.StatusCode = statusCode;

        var validationErrors = exception.Errors
            .GroupBy(e => e.PropertyName, e => e.ErrorMessage)
            .ToDictionary( e => e.Key, e => e.ToArray() );

        await problemDetailsService.TryWriteAsync( new ProblemDetailsContext
        {
            HttpContext = context,
            ProblemDetails = new ValidationProblemDetails
            {
                Title = "Validation Error Occured",
                Status = statusCode,
                Instance = context.Request.Path,
                Detail = exception.Message,
                Errors = validationErrors,
            },
            Exception = exception
        } );
    }

    private async Task WriteResponseAsync(HttpContext context, Exception exception)
    {
        logger.LogError( "Error occured {@exception}", exception );

        var statusCode = GetStatusCode(exception);
        context.Response.StatusCode = statusCode;

        var problemDetails = new ProblemDetails
        {
            Title = "An Error Occured",
            Status = statusCode,
            Instance = context.Request.Path,
            Detail = exception.Message,
        };

        if (env.IsDevelopment())
        {
            problemDetails.Extensions.Add("stackTrace", exception.StackTrace);
            problemDetails.Extensions.Add("innerMessage", exception.InnerException?.Message);
        }

        await problemDetailsService.TryWriteAsync( new ProblemDetailsContext
        {
            HttpContext = context,
            ProblemDetails = problemDetails,
            Exception = exception
        } );
    }

    private static int GetStatusCode(Exception exception) => exception switch
    {
        ValidationException _ => Status422UnprocessableEntity,
        ArgumentNullException _ => Status422UnprocessableEntity,
        TimeoutException _ => Status408RequestTimeout,
        NotImplementedException _ => Status501NotImplemented,
        HttpRequestException ex when ex.StatusCode is HttpStatusCode.Unauthorized or HttpStatusCode.Forbidden => (int)ex.StatusCode,
        _ => Status400BadRequest
    };
}