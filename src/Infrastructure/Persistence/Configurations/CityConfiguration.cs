using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Configurations
{
    class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.PostCode)
                .IsRequired()
                .HasMaxLength(8);

            builder.HasOne(e => e.Country)
                .WithMany(e => e.Cities)
                .HasForeignKey(e => e.CountryId);

            builder.HasMany(e => e.UserProfiles)
                .WithOne(e => e.City)
                .HasForeignKey(e =>e.CityId);

            builder.HasData(
                new City { Id = 1, Name = "Berezne", CountryId = 5, PostCode = "34600" },
                new City { Id = 2, Name = "Taipei", CountryId = 1, PostCode = "100-116" },
                new City { Id = 3, Name = "Tokyo", CountryId = 4, PostCode = "100-0000" },
                new City { Id = 4, Name = "Beijing", CountryId = 2, PostCode = "100000–102629" },
                new City { Id = 5, Name = "California", CountryId = 3, PostCode = "90201" },
                new City { Id = 6, Name = "Rivne", CountryId = 5, PostCode = "33000" },
                new City { Id = 7, Name = "Kiyiv", CountryId = 5, PostCode = "01001" }
                );
        }
    }
}
