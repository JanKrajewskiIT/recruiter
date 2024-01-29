using MediatR;
using Microsoft.EntityFrameworkCore;
using Questions.Application.Models;
using Questions.Infrastructure.Context;

namespace Questions.Application.Queries;

internal sealed class GetOffersQueryHandler( ApplicationDbContext dbContext ) : IRequestHandler<GetOffersQuery, IEnumerable<Offer>>
{
    public async Task<IEnumerable<Offer>> Handle( GetOffersQuery request, CancellationToken cancellationToken )
    {
        var questions = await dbContext.Offers
            .Where( x => x.Status == request.Status )
            .OrderBy( x => x.CreatedOn )
            .ToListAsync( cancellationToken );

        return questions
            .Select( x => new Offer( x.Id, x.Name, x.Link, x.Company, x.City, [.. x.Reasons], x.Description ) )
            .ToList();
    }
}
