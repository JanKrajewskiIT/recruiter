using MediatR;
using Microsoft.EntityFrameworkCore;
using Questions.Infrastructure.Context;

namespace Questions.Application.Command;

internal sealed class UpdateOfferStatusCommandHandler( ApplicationDbContext dbContext ) : INotificationHandler<UpdateOfferStatusCommand>
{
    public async Task Handle( UpdateOfferStatusCommand notification, CancellationToken cancellationToken )
    {
        var offerEntity = await dbContext.Offers
            .SingleAsync( o => o.Id == notification.Id, cancellationToken );

        offerEntity.Status = notification.Status;

        await dbContext.SaveChangesAsync( cancellationToken );
    }
}
