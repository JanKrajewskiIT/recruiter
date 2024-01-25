using MediatR;
using Questions.Domain.Entities;
using Questions.Domain.Enums;
using Questions.Infrastructure.Context;

namespace Questions.Application.Command;

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
