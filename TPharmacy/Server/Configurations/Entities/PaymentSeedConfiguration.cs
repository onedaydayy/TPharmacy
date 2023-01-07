using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TPharmacy.Shared.Domain;

namespace TPharmacy.Server.Configurations.Entities
{
    public class PaymentSeedConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.HasData(
                    new Payment
                    {
                        ID = 1,
                        OrderID = 1,
                        PayCardInfo = "7855-3798-2344-9853",
                        PayFee = 128.00m,
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    },
                    new Payment
                    {
                        ID = 2,
                        OrderID = 2,
                        PayCardInfo = "3244-2355-3459-9767",
                        PayFee = 103.00m,
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "System"
                    });
        }
    }
}
