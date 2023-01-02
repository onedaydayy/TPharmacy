namespace TPharmacy.Shared.Domain
{
    public class Prescription : BaseDomainModel
    {
        public virtual Consultation Consultation { get; set; }
        public int ConID { get; set; }
        public virtual Product Product { get; set; }
        public int ProductID { get; set; }
        public int PresQty { get; set; }
    }
}
