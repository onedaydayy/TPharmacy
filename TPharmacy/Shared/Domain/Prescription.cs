using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TPharmacy.Shared.Domain
{
    public class Prescription : BaseDomainModel
    {
        [Required]
        public virtual Consultation Consultation { get; set; }
        [Required]
        [ForeignKey("Consultation")]
        public int ConsultationID { get; set; }
        public virtual Product Product { get; set; }
        [Required]
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public int PresQty { get; set; }
    }
}
