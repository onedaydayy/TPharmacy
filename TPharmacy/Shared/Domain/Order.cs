using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPharmacy.Shared.Domain
{
    public class Order : BaseDomainModel
    {
        public enum Status
        {
            InProgress,
            Completed,
            Cancelled,
            Delivered
        }

        public Status OrderStatus { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }

        [ForeignKey("Staff")]
        public int StaffID { get; set; }
        public virtual Staff Staff { get; set; }
        public DateTime OrderDateTime { get; set; }

        [Column(TypeName = "decimal(7,2)")]
        public decimal OrderFee { get; set; }

        [Column(TypeName = "decimal(7,2)")]
        public decimal OrderTotal { get; set; }

        [Column(TypeName = "decimal(7,2)")]
        public decimal OrderItemTotal { get; set; }

        public virtual List<OrderItem> OrderItems { get; set; }
        public virtual List<Payment> Payments { get; set; }
        public void CalculateOrderTotal()
        {
            if (OrderItemTotal >= 200)
            {
                OrderFee = 0;
            }
            else
            {
                OrderFee = 10;
            }
            OrderTotal = OrderFee + OrderItemTotal;
        }
    }
}
