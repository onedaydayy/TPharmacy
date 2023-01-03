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
                        StafEmail = "woon@gmail.com",
                        StafPassword = "Woon1234*",
                        StafRole = "Pharmacist",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "June",
                        UpdatedBy = "System"
                    },
                    new Staff
                    {
                        ID = 2,
                        StafName = "June",
                        StafEmail = "june@gmail.com",
                        StafPassword = "June1234*",
                        StafRole = "Admin",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "June",
                        UpdatedBy = "System"
                    },
                    new Staff
                    {
                        ID = 3,
                        StafName = "Kate",
                        StafEmail = "kate@gmail.com",
                        StafPassword = "Kate1234*",
                        StafRole = "Packer",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "June",
                        UpdatedBy = "System"
                    }
                    );
        }
    }
}
