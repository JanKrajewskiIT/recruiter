using MediatR;
using Microsoft.AspNetCore.Mvc;
using Questions.Application.Queries;

namespace Questions.Api.Endopoints;

internal static class QuestionEndpoints
{
    public static WebApplication MapQuestionEndpoints( this WebApplication app )
    {
        app.MapGroup( "/questions" )
            .MapGet( "/", async ( [FromQuery] Guid categoryId, IMediator mediator ) =>
                            await mediator.Send( new GetQuestionsQuery( categoryId ) ) )
            .WithName( "GetQuestions" )
            .WithOpenApi()
            .RequireAuthorization();

        return app;
    }
}
