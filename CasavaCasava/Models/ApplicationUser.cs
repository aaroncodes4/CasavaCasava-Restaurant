﻿using Microsoft.AspNetCore.Identity;

namespace CasavaCasava.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Order>? Orders { get; set; }
    }
}
