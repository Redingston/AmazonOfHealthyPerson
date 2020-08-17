using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Configurations
{
    class PCategoryConfiguration : IEntityTypeConfiguration<PCategory>
    {
        public void Configure(EntityTypeBuilder<PCategory> builder)
        {
            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.HasMany(e => e.Products)
                .WithOne(e => e.Category);

            builder.HasData(
                new PCategory { Id = 1, Name = "Laptop" },
                new PCategory { Id = 2, Name = "CPU" },
                new PCategory { Id = 3, Name = "GPU" },
                new PCategory { Id = 4, Name = "Smart phone" },
                new PCategory { Id = 5, Name = "Refrigerator" },
                new PCategory { Id = 6, Name = "Smart TV" }
                );
        }
    }
}
