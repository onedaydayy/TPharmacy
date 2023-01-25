﻿using Microsoft.AspNetCore.Identity;

namespace TPharmacy.Server.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
    }
}
