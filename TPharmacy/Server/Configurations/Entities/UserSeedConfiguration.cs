using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TPharmacy.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TPharmacy.Server.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
            new ApplicationUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                FirstName = "Admin",
                LastName = "User",
                UserName = "Admin",
                NormalizedUserName = "ADMIN",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                SecurityStamp = Guid.NewGuid().ToString()
            },
            new ApplicationUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102e5",
                Email = "june@gmail.com",
                NormalizedEmail = "JUNE@GMAIL.COM",
                FirstName = "Admin",
                LastName = "User",
                UserName = "June",
                NormalizedUserName = "JUNE",
                PasswordHash = hasher.HashPassword(null, "June1234*"),
                SecurityStamp = Guid.NewGuid().ToString()
            },
            new ApplicationUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102c4",
                Email = "james@gmail.com",
                NormalizedEmail = "JAMES@GMAIL.COM",
                FirstName = "Customer",
                LastName = "User",
                UserName = "Customer",
                NormalizedUserName = "CUSTOMER",
                PasswordHash = hasher.HashPassword(null, "James1234*"),
                SecurityStamp = Guid.NewGuid().ToString()
            }
            );
        }
    }
}

