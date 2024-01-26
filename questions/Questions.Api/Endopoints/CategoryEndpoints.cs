using MediatR;
using Questions.Application.Queries;

namespace Questions.Api.Endopoints;

internal static class CategoryEndpoints
{
    public static WebApplication MapCategoryEndpoints( this WebApplication app )
    {
        var group = app
            .MapGroup( "/categories" )
            .WithOpenApi()
            .RequireAuthorization();

        group.MapGet( "/", async ( IMediator mediator ) =>
                await mediator.Send( new GetCategoriesQuery() ) )
            .WithName( "GetCategories" );

        return app;
    }
}
