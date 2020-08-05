using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations
{
    class BasketConfiguration : IEntityTypeConfiguration<Basket>
    {
        public void Configure(EntityTypeBuilder<Basket> builder)
        {
            builder.HasOne(e => e.Order)
                .WithOne(e => e.Basket)
                .HasForeignKey<Order>(e => e.BasketId);

            builder.HasMany(e => e.Products)
                .WithOne(e => e.Basket);
        }
    }
}
