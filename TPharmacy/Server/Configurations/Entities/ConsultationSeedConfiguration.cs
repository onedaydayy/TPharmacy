using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TPharmacy.Shared.Domain;

namespace TPharmacy.Server.Configurations.Entities
{
    public class ConsultationSeedConfiguration : IEntityTypeConfiguration<Consultation>
    {
        public void Configure(EntityTypeBuilder<Consultation> builder)
        {
            builder.HasData(
                    new Consultation
                    {
                        ID = 1,
                        CustomerID = 1,
                        StaffID = 2,
                        ConDate = DateTime.Now,
                        ConStartTime = DateTime.Now,
                        ConEndTime = DateTime.Now.AddHours(+1.15),
                        ConFee = 35.50m,
                        ConDesc = "Flu Consultation",
                        ConStatus = "Completed",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "Woon",
                        UpdatedBy = "System"
                    },
                    new Consultation
                    {
                        ID = 2,
                        CustomerID = 3,
                        StaffID = 2,
                        ConDate = DateTime.Now,
                        ConStartTime = DateTime.Now,
                        ConEndTime = DateTime.Now.AddHours(+1),
                        ConFee = 30.50m,
                        ConDesc = "Eczema Consultation",
                        ConStatus = "Pending",
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "Woon",
                        UpdatedBy = "System"
                    }
                    );
        }
    }
}
