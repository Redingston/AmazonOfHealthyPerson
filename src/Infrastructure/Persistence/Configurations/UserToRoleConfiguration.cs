using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Configurations
{
    class UserToRoleConfiguration : IEntityTypeConfiguration<UserToRole>
    {
        public void Configure(EntityTypeBuilder<UserToRole> builder)
        {
            builder.HasOne(e => e.Role)
                .WithMany(e => e.UserToRoles)
                .HasForeignKey(e => e.RoleId)
                .IsRequired();

            builder.HasOne(e => e.User)
                .WithMany(e => e.UserToRoles)
                .HasForeignKey(e => e.UserId)
                .IsRequired();
        }
    }
}
