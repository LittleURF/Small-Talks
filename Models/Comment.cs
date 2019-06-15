using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallTalks.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string CreatorId { get; set; }

        public ApplicationUser Creator { get; set; }

        public int PostId { get; set; }

        [Required]
        [StringLength(520, ErrorMessage = "Comment cannot be longer than 500 characters")]
        public string Content { get; set; }

        public DateTime CreationDate { get; set; }

        public List<ChildComment> Comments { get; set; }

    }
}
