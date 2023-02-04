using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TPharmacy.Shared.Domain
{
    public class Consultation : BaseDomainModel
    {
        public virtual Customer Customer { get; set; }
        //[Required]
        [ForeignKey("Customer")]
        public int? CustomerID { get; set; }
        public virtual Staff Staff { get; set; }
        //[Required]
        [ForeignKey("Staff")]
        public int? StaffID { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ConDate { get; set; }
        public int ConDuration { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(7,2)")]
        public decimal ConFee { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Consultation Description is too short")]
        public string ConDesc { get; set; }
        public string ConStatus { get; set; }
        public virtual List<Prescription> Prescriptions { get; set; }
    }
}
