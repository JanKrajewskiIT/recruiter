using MediatR;
using Organizer.Domain.Entities;
using Organizer.Domain.Enums;
using Organizer.Infrastructure.Context;

namespace Organizer.Application.Command;

internal sealed class AddOfferCommandHandler( ApplicationDbContext dbContext ) : INotificationHandler<AddOfferCommand>
{
    public async Task Handle( AddOfferCommand notification, CancellationToken cancellationToken )
    {
        var offer = new OfferEntity
        {
            Name = notification.Offer.Name,
            Link = notification.Offer.Link,
            Company = notification.Offer.Company,
            City = notification.Offer.City,
            Status = OfferStatus.New,
            Description = notification.Offer.Description
        };

        await dbContext.Offers.AddAsync( offer, cancellationToken );
        await dbContext.SaveChangesAsync( cancellationToken );
    }
}
