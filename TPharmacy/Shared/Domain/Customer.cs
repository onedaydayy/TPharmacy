using System;
using System.Collections.Generic;

namespace TPharmacy.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string CusName { get; set; }
        public string CusEmail { get; set; }
        public string CusNumber { get; set; }
        public string CusAddress { get; set; }
        public string CusPassword { get; set; }
        public int CusPoints { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<Consultation> Consultations { get; set; }
    }
}
