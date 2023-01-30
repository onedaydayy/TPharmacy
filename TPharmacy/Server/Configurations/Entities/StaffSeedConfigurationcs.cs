﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TPharmacy.Shared.Domain;



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
                        ID = 2,
                        StafName = "Woon",
                        StafEmail = "woon@gmail.com",
                        StafPassword = "June1234*",
                        StafRole = "Pharmacist",
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
                        StafPassword = "June1234*",
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
