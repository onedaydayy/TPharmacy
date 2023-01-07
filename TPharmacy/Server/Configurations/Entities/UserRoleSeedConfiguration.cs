using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TPharmacy.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "staff",
                UserId = "3781efa7-66dc-47f0-860f-e506d04102s1"
            },  
            new IdentityUserRole<string>
            {
                RoleId = "admin",
                UserId = "3781efa7-66dc-47f0-860f-e506d04102s1"
            },
            new IdentityUserRole<string>
            {
                RoleId = "staff",
                UserId = "3781efa7-66dc-47f0-860f-e506d04102s2"
            },
            new IdentityUserRole<string>
            {
                RoleId = "pharmacist",
                UserId = "3781efa7-66dc-47f0-860f-e506d04102s2"
            },
             new IdentityUserRole<string>
             {
                 RoleId = "staff",
                 UserId = "3781efa7-66dc-47f0-860f-e506d04102s3"
             },
             new IdentityUserRole<string>
             {
                 RoleId = "packer",
                 UserId = "3781efa7-66dc-47f0-860f-e506d04102s3"
             },
            new IdentityUserRole<string>
            {
                RoleId = "customer",
                UserId = "3781efa7-66dc-47f0-860f-e506d04102c1"
            },
            new IdentityUserRole<string>
            {
                RoleId = "customer",
                UserId = "3781efa7-66dc-47f0-860f-e506d04102c2"
            },
            new IdentityUserRole<string>
            {
                RoleId = "customer",
                UserId = "3781efa7-66dc-47f0-860f-e506d04102c3"
            });
        }
    }
}
