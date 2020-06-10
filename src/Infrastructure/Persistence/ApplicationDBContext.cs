using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence
{
    public class ApplicationDBContext : DbContext, IAOHPDbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDBContext).Assembly);
        }
    }
}
