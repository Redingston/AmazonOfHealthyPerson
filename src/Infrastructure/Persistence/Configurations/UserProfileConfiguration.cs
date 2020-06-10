using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Configurations
{
    class UserProfileConfiguration : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> builder)
        {
            builder.Property(e => e.Name)
                .HasMaxLength(64)
                .IsRequired();

            builder.Property(e => e.SecondName)
               .IsRequired()
               .HasMaxLength(64);

            builder.Property(e => e.MiddleName)
               .IsRequired()
               .HasMaxLength(64);

            builder.Property(e => e.Phone)
              .IsRequired()
              .HasMaxLength(32);

            builder.Property(e => e.Photo)
              .IsRequired();

            builder.HasOne(e => e.User)
                .WithOne(e => e.UserProfile)
                .HasForeignKey<UserProfile>(e => e.Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Country)
               .WithOne(e => e.UserProfile);

            builder.HasOne(e => e.City)
               .WithOne(e => e.UserProfile);
        }
    }
}
