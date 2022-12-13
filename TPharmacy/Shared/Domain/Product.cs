using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPharmacy.Shared.Domain
{
    public class Product : BaseDomainModel
    {
        public string ProdBrand { get; set; }
        public string ProdName { get; set; }
        public string ProdDesc { get; set; }
        public decimal ProdPrice { get; set; }
    }
}
