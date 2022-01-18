using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using App.Models;

namespace App.Areas.Admin.Pages.Role
{
    public class RolePageModel : PageModel
    {
        protected readonly RoleManager<IdentityRole> _roleManager;
        protected readonly AppDbContext _context;

        public RolePageModel(RoleManager<IdentityRole> roleManger, AppDbContext context)
        {
            _roleManager = roleManger;
            _context = context;
        }

        [TempData]
        public string StatusMessage { get; set; }
    }
}