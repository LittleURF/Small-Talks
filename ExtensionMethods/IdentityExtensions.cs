using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SmallTalks.Data;
using SmallTalks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace SmallTalks.ExtensionMethods
{
    public static class IdentityExtensions
    {

        public static bool IsInAnyRole(this IPrincipal user, params string[] roles)
        {
            return roles.Any(user.IsInRole);
        }

    }
}
