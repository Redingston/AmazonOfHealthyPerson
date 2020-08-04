using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IAOHPDbContext
    {
        DbSet<Basket> Baskets { get; set; }
        DbSet<BasketToProduct> BasketToProducts { get; set; }
        DbSet<Brand> Brands { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<Country> Countries { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<PAdditionalInformaion> AdditionalInformaions { get; set; }
        DbSet<PaymentMethod> PaymentMethods { get; set; }
        DbSet<PCategory> Categories { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductToCategory> ProductToCategories { get; set; }
        DbSet<ProductToTag> ProductToTags { get; set; }
        DbSet<PTag> Tags { get; set; }
        DbSet<PTechnicalDetail> TechnicalDetails { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<ShippingFirm> ShippingFirms { get; set; }
        DbSet<Street> Streets { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<UserProfile> Classes { get; set; }
        DbSet<UserToRole> UserToRoles { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
