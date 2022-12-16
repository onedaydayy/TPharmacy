using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPharmacy.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        public string StafName { get; set; }
        public string StafEmail { get; set; }
        public string StafPassword { get; set; }
        public string StafRole { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<Consultation> Consultations { get; set; }
    }
}
