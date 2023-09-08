using Microsoft.AspNetCore.Mvc;

namespace PsychologyProject.Web.Controllers
{
    public class AboutUs : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
