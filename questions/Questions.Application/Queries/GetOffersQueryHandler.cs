using MediatR;
using Microsoft.EntityFrameworkCore;
using Questions.Application.Models;
using Questions.Infrastructure.Context;

namespace Questions.Application.Queries;

internal class GetOffersQueryHandler( ApplicationDbContext dbContext ) : IRequestHandler<GetOffersQuery, IEnumerable<Offer>>
{
    public async Task<IEnumerable<Offer>> Handle( GetOffersQuery request, CancellationToken cancellationToken )
    {
        var questions = await dbContext.Offers
            .Where( x => x.Status == request.Status )
            .ToListAsync( cancellationToken );

        return questions
            .Select( x => new Offer( x.Name, x.CompanyName, x.Link, x.Description ) )
            .ToList();
    }
}
