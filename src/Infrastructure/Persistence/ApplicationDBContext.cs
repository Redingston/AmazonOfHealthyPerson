using Application.Common.Interfaces;
using Domain.Entities;
using IdentityServer4.EntityFramework.Options;
using Infrastructure.Identity;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContext : KeyApiAuthorizationDbContext<User, Role, long>, IAOHPDbContext
    {

        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
          
        }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketToProduct> BasketToProducts { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<PAdditionalInformaion> AdditionalInformaions { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<PCategory> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductToCategory> ProductToCategories { get; set; }
        public DbSet<ProductToTag> ProductToTags { get; set; }
        public DbSet<PTag> Tags { get; set; }
        public DbSet<PTechnicalDetail> TechnicalDetails { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<ShippingFirm> ShippingFirms { get; set; }
        public DbSet<Street> Streets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserProfile> Classes { get; set; }
        public DbSet<UserToRole> UserToRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
