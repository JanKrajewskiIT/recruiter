using MediatR;
using Microsoft.EntityFrameworkCore;
using Organizer.Infrastructure.Context;

namespace Organizer.Application.Command;

internal sealed class DeleteOfferCommandHandler( ApplicationDbContext dbContext ) : INotificationHandler<DeleteOfferCommand>
{
    public async Task Handle( DeleteOfferCommand notification, CancellationToken cancellationToken )
    {
        await dbContext.Offers
            .Where( o => o.Id == notification.Id )
            .ExecuteDeleteAsync( cancellationToken );
    }
}
