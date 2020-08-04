using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Configurations
{
    class BasketToProductConfiguration : IEntityTypeConfiguration<BasketToProduct>
    {
        public void Configure(EntityTypeBuilder<BasketToProduct> builder)
        {
            builder.HasKey(e => new { e.BasketId, e.ProductId });

            builder.HasOne(e => e.Basket)
                .WithMany(e => e.Products)
                .HasForeignKey(e => e.BasketId)
                .IsRequired();

            builder.HasOne(e => e.Product)
                .WithMany(e => e.Baskets)
                .HasForeignKey(e => e.ProductId)
                .IsRequired();
        }
    }
}
