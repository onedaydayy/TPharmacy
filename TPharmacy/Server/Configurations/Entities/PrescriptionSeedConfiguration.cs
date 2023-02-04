using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TPharmacy.Shared.Domain;


namespace TPharmacy.Server.Configurations.Entities
{
    public class PrescriptionSeedConfiguration : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder.HasData(
                    new Prescription
                    {
                        ID = 1,
                        PresQty = 1,
                        ConsultationID = 1,
                        ProductID = 4,
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    },
                    new Prescription
                    {
                        ID = 2,
                        PresQty = 2,
                        ConsultationID = 2,
                        ProductID = 4,
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    }
                    );
        }

    }
}
