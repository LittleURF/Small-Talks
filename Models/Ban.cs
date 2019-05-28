using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmallTalks.Models
{
    public class Ban
    {
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; } // Uses a SQL trigger to calculate EndTime
        public TimeSpan Duration { get; set; }
        public bool? IsActive { get; set; }
    }
}
