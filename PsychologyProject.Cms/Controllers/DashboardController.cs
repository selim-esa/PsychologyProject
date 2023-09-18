using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PsychologyProject.Cms.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
         
            return View();
        }
    }
}
