using MediatR;
using Microsoft.AspNetCore.Mvc;
using Questions.Application.Queries;

namespace Questions.Api.Endopoints;

internal static class QuestionEndpoints
{
    public static WebApplication MapQuestionEndpoints( this WebApplication app )
    {
        var group = app
            .MapGroup( "/questions" )
            .WithOpenApi()
            .RequireAuthorization();

        group.MapGet( "/", async ( [FromQuery] Guid categoryId, IMediator mediator ) =>
                await mediator.Send( new GetQuestionsQuery( categoryId ) ) )
            .WithName( "GetQuestions" );

        return app;
    }
}
