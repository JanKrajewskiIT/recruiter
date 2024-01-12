using MediatR;
using Microsoft.EntityFrameworkCore;
using Questions.Application.Models;
using Questions.Domain.Entities;
using Questions.Infrastructure.Context;

namespace Questions.Application.Queries;

internal class GetCategoriesQueryHandler( ApplicationDbContext dbContext ) : IRequestHandler<GetCategoriesQuery, IEnumerable<Category>>
{
    public async Task<IEnumerable<Category>> Handle( GetCategoriesQuery request, CancellationToken cancellationToken )
    {
        var categories = await dbContext.Categories
            .Where( x => !x.ParentCategoryId.HasValue )
            .Include( x => x.ChildCategories.OrderBy( c => c.Order ) )
            .OrderBy( x => x.Order )
            .ToListAsync( cancellationToken );

        return MapCategories( categories );
    }

    private List<Category> MapCategories( IEnumerable<CategoryEntity> categories )
        => categories.Select( MapCategory ).ToList();

    private Category MapCategory( CategoryEntity entity )
        => new(
            entity.Name,
            entity.Description,
            entity.IconName,
            MapCategories( entity.ChildCategories ) );
}
