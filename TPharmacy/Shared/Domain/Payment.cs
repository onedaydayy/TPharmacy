using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPharmacy.Shared.Domain
{
    public class Payment : BaseDomainModel
    {
        [Required]
        [ForeignKey("Order")]
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }

        [Column(TypeName = "decimal(7,2)")]
        public decimal PayFee { get; set; }
        public string PayCardInfo { get; set; }

    }
}
