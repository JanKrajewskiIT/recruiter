using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PGPlatform.ManagementPortal.Infrastructure.Database.Consts;
using Questions.Domain.Entities;

namespace Questions.Infrastructure.EntitiesConfiguration;

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
