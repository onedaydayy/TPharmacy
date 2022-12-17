using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPharmacy.Shared.Domain
{
    public class Product : BaseDomainModel
    {
        public string ProdBrand { get; set; }
        public string ProdName { get; set; }
        public string ProdDesc { get; set; }

        [Column(TypeName = "decimal(7,2)")]
        public decimal ProdPrice { get; set; }
        public virtual List<OrderItem> OrderItems { get; set; }
        public virtual List<Prescription> Prescriptions { get; set; }
    }
}
