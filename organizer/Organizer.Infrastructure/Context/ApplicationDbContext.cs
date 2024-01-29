using Microsoft.EntityFrameworkCore;
using Organizer.Domain.Entities;
using Organizer.Domain.Enums;
using Organizer.Infrastructure.EntitiesConfiguration;

namespace Organizer.Infrastructure.Context;

public class ApplicationDbContext( DbContextOptions<ApplicationDbContext> options ) : DbContext( options )
{
    public virtual DbSet<OfferEntity> Offers { get; init; }

    public virtual DbSet<KeyValueListEntity> KeyValueLists { get; init; }

    protected override void OnModelCreating( ModelBuilder modelBuilder )
    {
        modelBuilder.HasPostgresEnum<DictionaryKey>();
        modelBuilder.HasPostgresEnum<OfferStatus>();

        modelBuilder.SeedData();
        modelBuilder.ApplyConfigurationsFromAssembly( typeof( OfferConfiguration ).Assembly );
    }
}