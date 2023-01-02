using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TPharmacy.Server.Models;

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
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PhoneNumber= "0000",
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
                FirstName = "Admin",
                LastName = "User",
                UserName = "june@gmail.com",
                NormalizedUserName = "JUNE@GMAIL.COM",
                PhoneNumber = "0000",
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
                Email = "james@gmail.com",
                NormalizedEmail = "JAMES@GMAIL.COM",
                FirstName = "Customer",
                LastName = "User",
                UserName = "james@gmail.com",
                NormalizedUserName = "JAMES@GMAIL.COM",
                PhoneNumber = "1111",
                EmailConfirmed = true,
                LockoutEnabled = true,
                PhoneNumberConfirmed = true,
                Address = "Tampines Ave 1",
                Password = "James1234*",
                PasswordHash = hasher.HashPassword(null, "James1234*"),
                SecurityStamp = Guid.NewGuid().ToString()
            }
            );
        }
    }
}

