using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TPharmacy.Shared.Domain
{
    public class Product : BaseDomainModel
    {
        [Required]
        public string ProdBrand { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Product Name is too short")]
        public string ProdName { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Product Description is too short")]
        public string ProdDesc { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(7,2)")]
        public decimal ProdPrice { get; set; }
        public string ProdCategory { get; set; }
        public virtual List<OrderItem> OrderItems { get; set; }
        public virtual List<Prescription> Prescriptions { get; set; }
    }
}
