using Microsoft.AspNetCore.Identity;
using Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Context
{
    public class ApplicationDbSeeder
    {
        private readonly UserManager<ApplicationUser> _userManager;

        private readonly RoleManager<ApplicationRole> _roleManager;


    }
}
