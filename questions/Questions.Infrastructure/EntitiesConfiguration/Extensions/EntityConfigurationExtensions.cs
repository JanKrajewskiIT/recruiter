using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PGPlatform.ManagementPortal.Infrastructure.Database.Consts;
using Questions.Domain.Entities;

namespace Questions.Infrastructure.EntitiesConfiguration.Extensions;

internal static class EntityConfigurationExtensions
{
    internal static void ToBasicTable<T>( this EntityTypeBuilder<T> builder, string tableName ) where T : BaseEntity
    {
        builder.ToTable( tableName );
        builder.HasKey( e => e.Id );
    }

    internal static void ToAuditTable<T>( this EntityTypeBuilder<T> builder, string tableName ) where T : AuditEntity
    {
        builder.ToBasicTable( tableName );

        builder.Property( e => e.CreatedBy )
            .IsRequired();

        builder.Property( e => e.CreatedOn )
            .HasDefaultValueSql( PostgresCommandConsts.CurrentTimeStamp )
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property( e => e.ModifiedBy )
            .IsRequired();

        builder.Property( e => e.ModifiedOn )
            .HasDefaultValueSql( PostgresCommandConsts.CurrentTimeStamp )
            .ValueGeneratedOnUpdate()
            .IsRequired();
    }
}