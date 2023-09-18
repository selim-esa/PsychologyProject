using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PsychologyProject.Cms.Models;
using PsychologyProject.Entities.Concrete;

namespace PsychologyProject.Cms.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public AccountController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
      
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
  
        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "HomePage");
                }
                else
                {
                    return RedirectToAction("Index", "Account");
                }
            }

            return View();
        }       
        [HttpGet]
        public async Task <IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Account");
        }
    }
}
