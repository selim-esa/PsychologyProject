using Microsoft.AspNetCore.Mvc;

namespace PsychologyProject.Web.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
