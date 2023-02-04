using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TPharmacy.Shared.Domain
{
    public class Consultation : BaseDomainModel, IValidatableObject
    {
        public virtual Customer Customer { get; set; }
        [Required]
        [ForeignKey("Customer")]
        public int? CustomerID { get; set; }
        public virtual Staff Staff { get; set; }
        [Required]
        [ForeignKey("Staff")]
        public int? StaffID { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ConDate { get; set; }
        public DateTime? ConStartTime { get; set; }
        public DateTime ConEndTime { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(7,2)")]
        public decimal ConFee { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Consultation Description is too short")]
        public string ConDesc { get; set; }
        public string ConStatus { get; set; }
        public virtual List<Prescription> Prescriptions { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //throw new NotImplementedException();
            if (ConStartTime != null)
            {
                if (ConEndTime <= ConStartTime)
                {
                    yield return new ValidationResult("Consultation End Time must be greater than Consultation Start Time", new[] { "Consultation End Time" });
                }
            }
        }
    }
}
