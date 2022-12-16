using TPharmacy.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
                        CusID = 1,
                        StaffID = 1,
                        ConDate = DateTime.Now,
                        ConStartTime = DateTime.Now,
                        ConEndTime = DateTime.Now.AddHours(+1.15),
                        ConFee = 35.50m,
                        ConDesc = "Flu Consultation",
                        DateCreated = DateTime.Now,
                        DataUpdated = DateTime.Now,
                        CreatedBy = "Woon",
                        UpdatedBy = "System"
                    },
                    new Consultation
                    {
                        ID = 2,
                        CusID = 3,
                        StaffID = 1,
                        ConDate = DateTime.Now,
                        ConStartTime = DateTime.Now,
                        ConEndTime = DateTime.Now.AddHours(+1),
                        ConFee = 30.50m,
                        ConDesc = "Eczema Consultation",
                        DateCreated = DateTime.Now,
                        DataUpdated = DateTime.Now,
                        CreatedBy = "Woon",
                        UpdatedBy = "System"
                    }
                    );
        }
    }
}
