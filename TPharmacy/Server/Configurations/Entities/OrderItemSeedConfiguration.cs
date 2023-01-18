using TPharmacy.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TPharmacy.Server.Configurations.Entities
{
    public class OrderItemSeedConfiguration : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasData(
                    new OrderItem
                    {
                        ID = 1,
                        OrderID = 1,
                        ProductID = 1,
                        OrderItemQtny = 2,
                        OrderItemTotal= 35.00m * 2,
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "Kate"
                    },
                    new OrderItem
                    {
                        ID = 2,
                        OrderID = 1,
                        ProductID = 2,
                        OrderItemQtny = 1,
                        OrderItemTotal = 58.00m * 1,
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "Kate"
                    },
                    new OrderItem
                    {
                        ID = 3,
                        OrderID = 2,
                        ProductID = 3,
                        OrderItemQtny = 2,
                        OrderItemTotal = 45.00m * 2,
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "Kate"
                    });
        }
    }
}
