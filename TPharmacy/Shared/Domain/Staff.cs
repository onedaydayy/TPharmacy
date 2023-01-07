using System.Collections.Generic;

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
