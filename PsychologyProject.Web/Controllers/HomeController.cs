using Microsoft.AspNetCore.Mvc;
using PsychologyProject.Business.Abstract;
using PsychologyProject.Entities.Enums;
using PsychologyProject.DataAccess.Concrete;
using PsychologyProject.Web.ViewModel;


namespace PsychologyProject.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;
        private readonly DataContext _context;

        public HomeController(IHomeService homeService, DataContext context)
        {
            _homeService = homeService;
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            model.Home = _context.homes.FirstOrDefault();
            model.Brief = _context.briefs.ToList();
            model.Sliders = _context.sliders.Where(x => x.Type.Contains("Home")).ToList();
              //model.SliderSecond = _context.sliders.Where(x => x.SliderType == PageTypes.HomeSecond.ToString()).FirstOrDefault();

            return View(model);
        }
    }
}
