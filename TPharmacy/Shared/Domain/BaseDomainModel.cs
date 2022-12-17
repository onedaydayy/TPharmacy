using System;

namespace TPharmacy.Shared.Domain
{
    public abstract class BaseDomainModel
    {
        public int ID { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DataUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
    }

}
