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

            builder.HasData(
                new Brand { Id = 1, Name = "Asus", FullName = "ASUS", CountryRegistrationId = 1 },
                new Brand { Id = 2, Name = "Lenovo", FullName = "LENOVO", CountryRegistrationId = 2 },
                new Brand { Id = 3, Name = "AMD", FullName = "AMD", CountryRegistrationId = 3 },
                new Brand { Id = 4, Name = "Intel", FullName = "INTEL", CountryRegistrationId = 3 },
                new Brand { Id = 5, Name = "Apple", FullName = "Apple", CountryRegistrationId = 3 },
                new Brand { Id = 6, Name = "Sunsung", FullName = "Sumsung", CountryRegistrationId = 4 },
                new Brand { Id = 7, Name = "SONY", FullName = "SONY", CountryRegistrationId = 4 }
                );
        }
    }
}
