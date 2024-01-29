using Extensions.Infrastructure.EntitiesConfiguration.Consts;
using Extensions.Infrastructure.EntitiesConfiguration.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Questions.Domain.Entities;

namespace Questions.Infrastructure.EntitiesConfiguration;

internal sealed class QuestionConfiguration : IEntityTypeConfiguration<QuestionEntity>
{
    public void Configure( EntityTypeBuilder<QuestionEntity> builder )
    {
        builder.ToAuditTable( "Questions" );

        builder.Property( e => e.Name )
            .HasMaxLength( DataTypeConsts.TextLength )
            .IsRequired();

        builder.Property( e => e.Description )
            .HasMaxLength( DataTypeConsts.TextLength )
            .IsRequired( false );

        builder.Property( e => e.CategoryId )
            .IsRequired();
    }
}
