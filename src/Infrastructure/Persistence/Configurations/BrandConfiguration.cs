using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Configurations
{
    class BrandConfiguration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(e => e.FullName)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(e => e.Country)
                .WithMany(e => e.Brands)
                .HasForeignKey(e => e.CountryRegistrationId);
        }
    }
}
