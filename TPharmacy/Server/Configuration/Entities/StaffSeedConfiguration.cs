using TPharmacy.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TPharmacy.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                    new Staff
                    {
                        ID = 1,
                        StafName = "Woon",
                        StafEmailAddress = "woon@gmail.com",
                        StafPassword = "Woon1234*",
                        StafRole = "Pharmacist",
                        DateCreated = DateTime.Now,
                        DataUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    },
                    new Staff
                    {
                        ID = 2,
                        StafName = "June",
                        StafEmailAddress= "june@gmail.com",
                        StafPassword= "June1234*",
                        StafRole= "Admin",
                        DateCreated = DateTime.Now,
                        DataUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    },
                    new Staff
                    {
                        ID = 2,
                        StafName = "Kate",
                        StafEmailAddress = "kate@gmail.com",
                        StafPassword = "Kate1234*",
                        StafRole = "Packer",
                        DateCreated = DateTime.Now,
                        DataUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    }
                    );
        }
    }
}
