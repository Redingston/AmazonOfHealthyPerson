using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Configurations
{
    class ProductToCategoryConfiguration : IEntityTypeConfiguration<ProductToCategory>
    {
        public void Configure(EntityTypeBuilder<ProductToCategory> builder)
        {
            builder.HasKey(e => new { e.CategoryId, e.ProductId });

            builder.HasOne(e => e.Category)
                .WithMany(e => e.Products)
                .HasForeignKey(e => e.CategoryId)
                .IsRequired();

            builder.HasOne(e => e.Product)
                .WithMany(e => e.Categories)
                .HasForeignKey(e => e.ProductId)
                .IsRequired();
        }
    }
}