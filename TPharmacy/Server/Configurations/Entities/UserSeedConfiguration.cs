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
                LastName = "Admin",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PhoneNumber= "6721 9632",
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
                Address= "TPharmacy",
                Password = "P@ssword1",
                PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                SecurityStamp = Guid.NewGuid().ToString()
            },
            new ApplicationUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102e5",
                Email = "june@gmail.com",
                NormalizedEmail = "JUNE@GMAIL.COM",
                FirstName = "June",
                LastName = "Admin",
                UserName = "june@gmail.com",
                NormalizedUserName = "JUNE@GMAIL.COM",
                PhoneNumber = "9273 8983",
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
                Address = "TPharmacy",
                Password = "June1234*",
                PasswordHash = hasher.HashPassword(null, "June1234*"),
                SecurityStamp = Guid.NewGuid().ToString()
            },
            new ApplicationUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102c4",
                Email = "sheila@gmail.com",
                NormalizedEmail = "SHEILA@GMAIL.COM",
                FirstName = "Sheila",
                LastName = "User",
                UserName = "sheila@gmail.com",
                NormalizedUserName = "SHEILA@GMAIL.COM",
                PhoneNumber = "8211 7319",
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
                Address = "1 Youngberg Terrace",
                Password = "Sheila1234*",
                PasswordHash = hasher.HashPassword(null, "Sheila1234*"),
                SecurityStamp = Guid.NewGuid().ToString()
            }
            );
        }
    }
}

