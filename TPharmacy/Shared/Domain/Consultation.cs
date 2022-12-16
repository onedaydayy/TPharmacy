using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPharmacy.Shared.Domain
{
    public class Consultation: BaseDomainModel
    {
        public virtual Customer Customer { get; set; }
        public int CusID { get; set; }
        public virtual Staff Staff { get; set; }
        public int StaffID { get; set; }
        public DateTime ConDate { get; set; }
        public DateTime ConStartTime { get; set; }
        public DateTime ConEndTime { get; set; }

        [Column(TypeName = "decimal(7,2)")]
        public decimal ConFee { get; set; }
        public string ConDesc { get; set; }
        public virtual List<Prescription> Prescriptions { get; set; }

    }
}
