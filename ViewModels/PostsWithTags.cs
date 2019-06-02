using SmallTalks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallTalks.ViewModels
{
    public class PostsWithTags
    {
        public List<Post> Posts { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
