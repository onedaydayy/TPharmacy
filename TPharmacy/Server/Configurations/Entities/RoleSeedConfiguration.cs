using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TPharmacy.Server.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
             new IdentityRole
             {
                 Id = "staff",
                 Name = "Staff",
                 NormalizedName = "STAFF"
             },
             new IdentityRole
             {
                 Id = "customer",
                 Name = "Customer",
                 NormalizedName = "CUSTOMER"
             },
             new IdentityRole
             {
                 Id = "admin",
                 Name = "Admin",
                 NormalizedName = "ADMIN"
             },
             new IdentityRole
             {
                 Id = "pharmacist",
                 Name = "Pharmacist",
                 NormalizedName = "PHARMACIST"
             },
             new IdentityRole
             {
                 Id = "packer",
                 Name = "Packer",
                 NormalizedName = "PACKER"
             });
        }
    }
}