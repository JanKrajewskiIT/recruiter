using MediatR;
using Microsoft.EntityFrameworkCore;
using Organizer.Infrastructure.Context;

namespace Organizer.Application.Command;

internal sealed class UpdateOfferStateCommandHandler( ApplicationDbContext dbContext ) : INotificationHandler<UpdateOfferStateCommand>
{
    public async Task Handle( UpdateOfferStateCommand notification, CancellationToken cancellationToken )
    {
        if (notification.Id != notification.State.Id)
            throw new Exception( "Data inconsistency in offer state model" );

        var offerEntity = await dbContext.Offers
            .SingleAsync( o => o.Id == notification.State.Id, cancellationToken );

        offerEntity.Status = notification.State.Status;
        offerEntity.Reasons = notification.State.Reasons;

        await dbContext.SaveChangesAsync( cancellationToken );
    }
}
