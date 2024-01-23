using MediatR;
using Microsoft.AspNetCore.Mvc;
using Questions.Application.Queries;
using Questions.Domain.Enums;

namespace Questions.Api.Endopoints;

internal static class OfferEndpoints
{
    public static WebApplication MapOfferEndpoints( this WebApplication app )
    {
        app.MapGroup( "/offers" )
            .MapGet( "/", async ( [FromQuery] OfferStatus status, IMediator mediator ) 
                            => await mediator.Send( new GetOffersQuery( status ) ) )
            .WithName( "GetOffers" )
            .WithOpenApi()
            .RequireAuthorization();

        app.MapGroup( "/offers" )
            .MapGet( "/statuses", () => Enum.GetNames<OfferStatus>())
            .WithName( "GetOfferStatuses" )
            .WithOpenApi()
            .RequireAuthorization();

        return app;
    }
}
