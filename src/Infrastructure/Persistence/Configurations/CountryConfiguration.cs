using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Configurations
{
    class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasData(
                new Country { Id = 1, Name="Taiwan" },
                new Country { Id = 2, Name = "China" },
                new Country { Id = 3, Name = "USA" },
                new Country { Id = 4, Name = "Japan" },
                new Country { Id = 5, Name = "Ukraine" }
                );
        }
    }
}
