using MediatR;
using Microsoft.EntityFrameworkCore;
using Organizer.Application.Models;
using Organizer.Infrastructure.Context;

namespace Organizer.Application.Queries;

internal sealed class GetOffersQueryHandler( ApplicationDbContext dbContext ) : IRequestHandler<GetOffersQuery, IEnumerable<Offer>>
{
    public async Task<IEnumerable<Offer>> Handle( GetOffersQuery request, CancellationToken cancellationToken )
    {
        var offers = await dbContext.Offers
            .Where( x => x.Status == request.Status )
            .OrderBy( x => x.CreatedOn )
            .ToListAsync( cancellationToken );

        return offers
            .Select( x => new Offer( x.Id, x.Name, x.Link, x.Company, x.City, [ .. x.Reasons ], x.Description ) )
            .ToList();
    }
}
