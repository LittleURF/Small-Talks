using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallTalks.Models
{
    public class Ban
    {
        public int Id { get; set; }

        public ApplicationUser User { get; set; }

        [Required]
        [InverseProperty("Id")]
        public string UserId { get; set; }

        public ApplicationUser BannedBy { get; set; }

        [InverseProperty("Id")]
        public string BannedById { get; set; }

        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        [NotMapped]
        public TimeSpan Duration { get; set; }
    }
}
