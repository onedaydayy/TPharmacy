using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TPharmacy.Shared.Domain
{
    public class Customer : BaseDomainModel
    {
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name does not meet length requirements")]
        public string CusName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email Address is not a valid email")]
        [EmailAddress]
        public string CusEmail { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "Contact Number is not a valid phone number")]
        public string CusNumber { get; set; }
        public string CusAddress { get; set; }
        public string CusPassword { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<Consultation> Consultations { get; set; }
    }
}
