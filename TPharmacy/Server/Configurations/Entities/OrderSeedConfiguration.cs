using TPharmacy.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TPharmacy.Server.Configurations.Entities
{
    public class OrderSeedConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
                    new Order
                    {
                        ID = 1,
                        CusID = 1,
                        StaffID = 3,
                        OrderDateTime = DateTime.Now,
                        OrderPrice = 128.00m,
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "Kate"
                    },
                    new Order
                    {
                        ID = 2,
                        CusID = 2,
                        StaffID = 3,
                        OrderDateTime = DateTime.Now,
                        OrderPrice = 90.00m,
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "Kate"
                    });
        }
    }
}
