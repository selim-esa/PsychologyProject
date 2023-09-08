using Microsoft.AspNetCore.Mvc;
using PsychologyProject.Business.Abstract;

namespace PsychologyProject.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        public IActionResult Index()
        {
            var values = _homeService.TGetList();
            return View(values);
        }
    }
}
