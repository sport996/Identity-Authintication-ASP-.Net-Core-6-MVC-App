﻿using Microsoft.AspNetCore.Identity;

namespace IdentityMvcApp.Data
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string ? Name { get; set; }
        [PersonalData]
        public DateTime DOB { get; set; }
    }
}
