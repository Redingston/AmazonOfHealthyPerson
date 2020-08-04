using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Configurations
{
    class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(e => e.Name)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(e => e.FullName)
               .IsRequired()
               .HasMaxLength(150);

            builder.Property(e => e.Price)
               .IsRequired();

            builder.Property(e => e.Amount)
              .IsRequired();
            builder.Property(e => e.Description)
              .IsRequired()
              .HasMaxLength(1000);

            builder.HasOne(e => e.Brand)
                .WithMany(e => e.Products)
                .HasForeignKey(e => e.BrandId);

            builder.HasMany(e => e.Photos)
                .WithOne(e => e.Product);

            builder.HasOne(e => e.AdditionalInformaion)
                .WithOne(e => e.Product)
                .HasForeignKey<PAdditionalInformaion>(e=>e.ProductId);

            builder.HasOne(e => e.TechicalDetail)
                .WithOne(e => e.Product)
                .HasForeignKey<PTechnicalDetail>(e=>e.ProductId);
        }
    }
}
