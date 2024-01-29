using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Organizer.Domain.Entities;

namespace Organizer.Infrastructure.EntitiesConfiguration;

internal sealed class KeyValueListConfiguration : IEntityTypeConfiguration<KeyValueListEntity>
{
    public void Configure( EntityTypeBuilder<KeyValueListEntity> builder )
    {
        builder.ToTable( "KeyValueLists" );

        builder.HasKey( e => e.Key );

        builder.Property( e => e.Key )
            .IsRequired();

        builder.Property( e => e.Values )
            .IsRequired();
    }
}
