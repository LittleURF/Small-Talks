using Microsoft.AspNetCore.Identity;
using SmallTalks.Enums;
using System;
using System.Collections.Generic;
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
        public int  CurrentBanId{ get; set; }
        public int Points { get; set; }
    }
}
