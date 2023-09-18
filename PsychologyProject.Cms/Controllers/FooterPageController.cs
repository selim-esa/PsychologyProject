using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace PsychologyProject.Cms.Controllers
{
    
    public class FooterPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
