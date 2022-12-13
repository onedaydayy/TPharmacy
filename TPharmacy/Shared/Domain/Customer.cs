using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPharmacy.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        public string CusName { get; set; }
        public string CusEmail { get; set; }
        public string CusAddress { get; set; }
        public string CusPassword { get; set; }
        public int CusPoints { get; set; }
    }
}
