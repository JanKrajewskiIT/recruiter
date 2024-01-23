using Microsoft.EntityFrameworkCore;
using Questions.Domain.Entities;
using Questions.Infrastructure.EntitiesConfiguration;

namespace Questions.Infrastructure.Context;

public class ApplicationDbContext( DbContextOptions<ApplicationDbContext> options ) : DbContext( options )
{
    public virtual DbSet<QuestionEntity> Questions { get; init; }

    public virtual DbSet<CategoryEntity> Categories { get; init; }

    public virtual DbSet<OfferEntity> Offers { get; init; }

    protected override void OnModelCreating( ModelBuilder modelBuilder )
    {
        modelBuilder.SeedData();
        modelBuilder.ApplyConfigurationsFromAssembly( typeof( QuestionConfiguration ).Assembly );
    }
}