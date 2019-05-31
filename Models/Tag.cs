using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallTalks.Models
{
    public class Tag
    {
        public int Id { get; set; }

        public string Name{ get; set; }

        public string Description { get; set; }

        [NotMapped]
        public bool IsActive { get; set; }

    }
}
