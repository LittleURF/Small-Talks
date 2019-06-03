using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallTalks.Models
{
    public class ChildComment
    {
        public int Id { get; set; }

        public string CreatorId { get; set; }

        public ApplicationUser Creator { get; set; }

        public int PostId { get; set; }

        public int CommentId { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreationDate { get; set; }

    }
}
