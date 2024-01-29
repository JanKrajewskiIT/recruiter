﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Organizer.Application.Command;
using Organizer.Application.Models;
using Organizer.Application.Queries;
using Organizer.Domain.Enums;

namespace Organizer.Api.Endopoints;

internal static class OfferEndpoints
{
    public static WebApplication MapOfferEndpoints( this WebApplication app )
    {
        var group = app
            .MapGroup( "/offers" )
            .WithOpenApi()
            .RequireAuthorization();

        group.MapGet( "/", async ( [FromQuery] OfferStatus status, IMediator mediator ) =>
                await mediator.Send( new GetOffersQuery( status ) ) )
            .WithName( "GetOffers" );

        group.MapPost( "/", async ( Offer offer, IMediator mediator ) =>
                await mediator.Publish( new AddOfferCommand( offer ) ) )
            .WithName( "AddOffer" );

        group.MapPut( "/{id}", async ( Guid id, Offer offer, IMediator mediator ) =>
                await mediator.Publish( new UpdateOfferCommand( id, offer ) ) )
            .WithName( "UpdateOffer" );

        group.MapPatch( "/{id}", async ( Guid id, OfferState state, IMediator mediator ) =>
                await mediator.Publish( new UpdateOfferStateCommand( id, state ) ) )
            .WithName( "UpdateOfferState" );

        group.MapDelete( "/{id}", async ( Guid id, IMediator mediator ) =>
                await mediator.Publish( new DeleteOfferCommand( id ) ) )
            .WithName( "DeleteOffer" );

        return app;
    }
}
