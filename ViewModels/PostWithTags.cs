using SmallTalks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallTalks.ViewModels
{
    public class PostWithTags
    {
        public Post Post { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
