using System;
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
        public decimal OrderPrice { get; set; }
        public virtual List<OrderItem> OrderItems { get; set; }
        public virtual List<Payment> Payments { get; set; }
    }
}