using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SmallTalks.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public string CreatorId { get; set; }

        [Required]
        public int PostId { get; set; }

        [Required]
        public bool IsParentComment { get; set; }

        public int? ParentCommentId { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
