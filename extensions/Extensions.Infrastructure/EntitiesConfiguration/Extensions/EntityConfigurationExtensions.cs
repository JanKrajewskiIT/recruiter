using Extensions.Domain.Entities;
using Extensions.Infrastructure.EntitiesConfiguration.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Extensions.Infrastructure.EntitiesConfiguration.Extensions;

public static class EntityConfigurationExtensions
{
    public static void ToBasicTable<T>( this EntityTypeBuilder<T> builder, string tableName ) where T : BaseEntity
    {
        builder.ToTable( tableName );
        builder.HasKey( e => e.Id );
    }

    public static void ToAuditTable<T>( this EntityTypeBuilder<T> builder, string tableName ) where T : AuditEntity
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