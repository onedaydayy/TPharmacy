using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TPharmacy.Shared.Domain;

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
                       CustomerID = 1,
                       StaffID = 3,
                       OrderDateTime = DateTime.Now,
                       OrderFee = 0.00m,
                       OrderTotal = 0.00m + 128.00m,
                       DateCreated = DateTime.Now,
                       DateUpdated = DateTime.Now,
                       CreatedBy = "System",
                       UpdatedBy = "Kate",
                       OrderStatus = Order.Status.InProgress
                   },
                    new Order
                    {
                        ID = 2,
                        CustomerID = 3,
                        StaffID = 3,
                        OrderDateTime = DateTime.Now,
                        OrderFee = 10.00m,
                        OrderTotal = 10.00m + 90.00m,
                        DateCreated = DateTime.Now,
                        DateUpdated = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedBy = "Kate",
                        OrderStatus = Order.Status.InProgress
                    });
        }
    }
}
