using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SmallTalks.Areas.Identity.Pages.Account
{
    public class AfterRegistrationModel : PageModel
    {
        public void OnGet()
        {
            RedirectToPage("./Login");
        }
    }
}