﻿using Microsoft.AspNetCore.Identity;
using SmallTalks.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallTalks.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base() { }

        public DateTime BirthDate { get; set; }
        public Sex Sex { get; set; }
        public bool AccountLocked { get; set; }

        public List<Ban> Bans { get; set; }
        public int? CurrentBanId{ get; set; }
        public int Points { get; set; }

        public virtual ICollection<IdentityUserRole<string>> Roles { get; } = new List<IdentityUserRole<string>>(); // From microsoft documentation 

        // To move out of here, model isnt a place for methods
        public int GetAge()
        {
            var today = DateTime.Today;
            var age = today.Year - BirthDate.Year;
            if (BirthDate.Date > today.AddYears(-age)) age--;

            return age;
        }
    }
}
