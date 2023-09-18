using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PsychologyProject.Entities.Concrete;

namespace AspNetCoreTodo.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class ManageUsersController : Controller
    {
        private readonly UserManager<AppRole> _userManager;

        public ManageUsersController(UserManager<AppRole> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var admins = await _userManager
                .GetUsersInRoleAsync("Administrator");

            var everyone = await _userManager.Users
                .ToArrayAsync();

            var model = new ManageUsersViewModel
            {
                Administrators = admins,
                Everyone = everyone
            };

            return View(model);
        }
    }
}