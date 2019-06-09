using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmallTalks.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string CreatorId { get; set; }

        public ApplicationUser Creator { get; set; }

        public List<Comment> Comments { get; set; }

        public List<PostTags> PostTags { get; set; }


        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime CreationDate { get; set; }

    }
}
