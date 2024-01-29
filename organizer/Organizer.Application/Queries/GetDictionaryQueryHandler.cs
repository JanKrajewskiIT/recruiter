using MediatR;
using Microsoft.EntityFrameworkCore;
using Organizer.Infrastructure.Context;

namespace Organizer.Application.Queries;

internal sealed class GetDictionaryQueryHandler( ApplicationDbContext dbContext ) : IRequestHandler<GetDictionaryQuery, IEnumerable<string>>
{
    public async Task<IEnumerable<string>> Handle( GetDictionaryQuery request, CancellationToken cancellationToken )
    {
        var entity = await dbContext.KeyValueLists
            .SingleAsync( x => x.Key == request.Key, cancellationToken );

        return entity.Values;
    }
}
