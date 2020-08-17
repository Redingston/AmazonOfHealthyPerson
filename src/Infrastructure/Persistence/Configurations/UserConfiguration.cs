using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence.Configurations
{
    class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasOne(e => e.UserProfile)
                .WithOne(e => e.User);

            builder.HasData(
                new User { Id = 1, Email = "admin@gmail.com", UserName = "admin@gmail.com", PasswordHash = "admin10!", PhoneNumber = "038451269874",  }
                );
        }
    }
}
