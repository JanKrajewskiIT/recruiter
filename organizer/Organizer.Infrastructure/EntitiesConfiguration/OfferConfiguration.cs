﻿using Extensions.Infrastructure.EntitiesConfiguration.Consts;
using Extensions.Infrastructure.EntitiesConfiguration.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Organizer.Domain.Entities;
using Organizer.Domain.Enums;

namespace Organizer.Infrastructure.EntitiesConfiguration;

internal sealed class OfferConfiguration : IEntityTypeConfiguration<OfferEntity>
{
    public void Configure( EntityTypeBuilder<OfferEntity> builder )
    {
        builder.ToAuditTable( "Offers" );

        builder.Property( e => e.Name )
            .HasMaxLength( DataTypeConsts.NameLength )
            .IsRequired();

        builder.Property( e => e.Link )
            .HasMaxLength( DataTypeConsts.NameLength )
            .IsRequired();

        builder.Property( e => e.Company )
            .HasMaxLength( DataTypeConsts.NameLength )
            .IsRequired();

        builder.Property( e => e.City )
            .HasMaxLength( DataTypeConsts.NameLength )
            .IsRequired();

        builder.Property( e => e.Status )
            .HasDefaultValue( OfferStatus.New )
            .IsRequired();

        builder.Property( e => e.Reasons )
            .IsRequired( false );

        builder.Property( e => e.Description )
            .HasMaxLength( DataTypeConsts.TextLength )
            .IsRequired( false );
    }
}
