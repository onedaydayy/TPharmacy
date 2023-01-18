﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPharmacy.Shared.Domain
{
    public class Order : BaseDomainModel
    {
        public int CusID { get; set; }
        public virtual Customer Customer { get; set; }
        public int StaffID { get; set; }
        public virtual Staff Staff { get; set; }
        public DateTime OrderDateTime { get; set; }

        [Column(TypeName = "decimal(7,2)")]
        public decimal OrderFee{ get; set; }
        [Column(TypeName = "decimal(7,2)")]
        public decimal OrderTotal { get; set; }
        public virtual List<OrderItem> OrderItems { get; set; }
        public virtual List<Payment> Payments { get; set; }

        public void CalculateOrderTotal()
        {
            decimal orderItemTotal = 0;
            foreach (var orderItem in OrderItems)
            {
                if (orderItem.OrderID == this.ID)
                {
                    orderItemTotal += orderItem.OrderItemTotal;
                }
            }
            if (orderItemTotal >= 100)
            {
                OrderFee = 10;
            }
            else
            {
                OrderFee = 0;
            }
            OrderTotal = OrderFee + orderItemTotal;
        }
    }
}