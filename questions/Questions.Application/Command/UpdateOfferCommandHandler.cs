using MediatR;
using Microsoft.EntityFrameworkCore;
using Questions.Infrastructure.Context;

namespace Questions.Application.Command;

internal sealed class UpdateOfferCommandHandler( ApplicationDbContext dbContext ) : INotificationHandler<UpdateOfferCommand>
{
    public async Task Handle( UpdateOfferCommand notification, CancellationToken cancellationToken )
    {
        var offerEntity = await dbContext.Offers
            .SingleAsync( o => o.Id == notification.Offer.Id, cancellationToken );

        offerEntity.Name = notification.Offer.Name;
        offerEntity.Link = notification.Offer.Link;
        offerEntity.Company = notification.Offer.Company;
        offerEntity.City = notification.Offer.City;
        offerEntity.Description = notification.Offer.Description;

        await dbContext.SaveChangesAsync( cancellationToken );
    }
}
