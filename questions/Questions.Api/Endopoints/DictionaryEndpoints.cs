using MediatR;
using Questions.Application.Queries;
using Questions.Domain.Enums;

namespace Questions.Api.Endopoints;

internal static class DictionaryEndpoints
{
    public static WebApplication MapDictionaryEndpoints( this WebApplication app )
    {
        var group = app
            .MapGroup( "/dictionaries" )
            .WithOpenApi()
            .RequireAuthorization();

        group.MapGet( "/positions", async ( IMediator mediator ) =>
                await mediator.Send( new GetDictionaryQuery( DictionaryKey.Positions ) ) )
            .WithName( "GetPositions" );

        group.MapGet( "/cities", async ( IMediator mediator ) =>
                await mediator.Send( new GetDictionaryQuery( DictionaryKey.Cities ) ) )
            .WithName( "GetCities" );

        group.MapGet( "/reasons", async ( IMediator mediator ) =>
                await mediator.Send( new GetDictionaryQuery( DictionaryKey.Reasons ) ) )
            .WithName( "GetReasons" );

        return app;
    }
}
