using Extensions.Infrastructure.EntitiesConfiguration.Consts;
using Extensions.Infrastructure.EntitiesConfiguration.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Questions.Domain.Entities;

namespace Questions.Infrastructure.EntitiesConfiguration;

internal sealed class CategoryConfiguration : IEntityTypeConfiguration<CategoryEntity>
{
    public void Configure( EntityTypeBuilder<CategoryEntity> builder )
    {
        builder.ToBasicTable( "Categories" );

        builder.Property( e => e.Name )
            .HasMaxLength( DataTypeConsts.NameLength )
            .IsRequired();

        builder.Property( e => e.Description )
            .HasMaxLength( DataTypeConsts.TextLength )
            .IsRequired( false );

        builder.Property( e => e.IconName )
            .HasMaxLength( DataTypeConsts.NameLength )
            .IsRequired( false );

        builder.Property( e => e.Order )
            .IsRequired();

        builder.Property( e => e.ParentCategoryId )
            .IsRequired( false );

        builder.HasMany( e => e.ChildCategories )
            .WithOne()
            .HasForeignKey( e => e.ParentCategoryId )
            .IsRequired( false );

        builder.HasMany( e => e.Questions )
            .WithOne()
            .HasForeignKey( e => e.CategoryId )
            .IsRequired();
    }
}
