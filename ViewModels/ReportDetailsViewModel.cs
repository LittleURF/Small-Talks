using SmallTalks.Enums;
using SmallTalks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmallTalks.ViewModels
{
    public class ReportDetailsViewModel
    {
        public Report Report{ get; set; }
        public dynamic ReportedObject { get; set; }
        public Post Post { get; set; }

    }
}
