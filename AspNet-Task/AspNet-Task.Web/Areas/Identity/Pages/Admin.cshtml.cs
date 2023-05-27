using AspNet_Task.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace AspNet_Task.Web.Areas.Identity.Pages
{
    [Authorize(Roles = "Administrator")]
    public class AdminModel : PageModel
    {
        private readonly UserManager<IdentityUser> _userManager;

        public AdminModel(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public List<UserRoleViewModel> UserRoles { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            UserRoles = await GetUserRolesAsync();
            return Page();
        }

        private async Task<List<UserRoleViewModel>> GetUserRolesAsync()
        {
            var users = await _userManager.Users.ToListAsync();
            var userRoles = new List<UserRoleViewModel>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                var userRole = new UserRoleViewModel
                {
                    Email = user.Email,
                    Roles = roles.ToList()
                };

                userRoles.Add(userRole);
            }

            return userRoles;
        }

        }
}
