using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPharmacy.Shared.Domain
{
    public class Payment : BaseDomainModel
    {
        public int OrderID { get; set; }
        public virtual Order Order { get; set; }

        [Column(TypeName = "decimal(7,2)")]
        public decimal PayFee { get; set; }
        public string PayCardInfo { get; set; }
    }
}
