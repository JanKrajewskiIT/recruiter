using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PGPlatform.ManagementPortal.Infrastructure.Database.Consts;
using Questions.Domain.Entities;
using Questions.Infrastructure.EntitiesConfiguration.Extensions;

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
