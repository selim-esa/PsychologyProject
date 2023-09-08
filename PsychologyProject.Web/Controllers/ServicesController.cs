using Microsoft.AspNetCore.Mvc;

namespace PsychologyProject.Web.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
