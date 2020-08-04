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
        }
    }
}
