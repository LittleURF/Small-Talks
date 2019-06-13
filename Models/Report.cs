using SmallTalks.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmallTalks.Models
{
    public class Report
    {
        public int Id { get; set; }

        public ApplicationUser Reporter { get; set; }

        [Required]
        public string ReporterId { get; set; }

        [Required]
        public int ReportedObjectId { get; set; }

        [Required]
        public ObjectType ReportedObjectType { get; set; }

        public string Content { get; set; }
    }
}
