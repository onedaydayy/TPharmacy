﻿using System.ComponentModel.DataAnnotations.Schema;

namespace TPharmacy.Shared.Domain
{
    public class OrderItem : BaseDomainModel
    {
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public int OrderItemQtny { get; set; }
        [Column(TypeName = "decimal(7,2)")]
        public decimal OrderItemTotal
        {
            get
            {
                if (Product != null && Product.ID == ProductID)
                {
                    return Product.ProdPrice * OrderItemQtny;
                }
                return 0;
            }
            set { }
        }
    }
}
