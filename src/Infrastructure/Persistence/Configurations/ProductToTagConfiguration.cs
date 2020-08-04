using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Configurations
{
    class ProductToTagConfiguration : IEntityTypeConfiguration<ProductToTag>
    {
        public void Configure(EntityTypeBuilder<ProductToTag> builder)
        {
            builder.HasKey(e => new { e.TagId, e.ProductId });

            builder.HasOne(e => e.Tag)
                .WithMany(e => e.Products)
                .HasForeignKey(e => e.TagId)
                .IsRequired();

            builder.HasOne(e => e.Product)
                .WithMany(e => e.Tags)
                .HasForeignKey(e => e.ProductId)
                .IsRequired();
        }
    }
}
