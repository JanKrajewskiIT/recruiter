using MediatR;
using Questions.Application.Queries;

namespace Questions.Api.Endopoints;

internal static class CategoryEndpoints
{
    public static WebApplication MapCategoryEndpoints( this WebApplication app )
    {
        app.MapGroup( "/categories" )
            .MapGet( "/", async ( IMediator mediator ) =>
                            await mediator.Send( new GetCategoriesQuery() ) )
            .WithName( "GetCategories" )
            .WithOpenApi()
            .RequireAuthorization();

        return app;
    }
}
