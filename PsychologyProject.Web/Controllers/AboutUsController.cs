using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PsychologyProject.Business.Abstract;
using PsychologyProject.DataAccess.Concrete;
using PsychologyProject.Entities.Concrete;
using PsychologyProject.Web.ViewModel;

namespace PsychologyProject.Web.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly IAboutUsService _aboutUsService;
        private readonly DataContext _context;


		public AboutUsController(IAboutUsService aboutUsService, DataContext context)
		{
			_aboutUsService = aboutUsService;
			_context = context;
		}

		[HttpGet]
        public IActionResult Index()
        {
            //var values = _aboutUsService.TGetList();
			AboutUsViewModel model = new AboutUsViewModel();
			model.AboutUs = _context.aboutUs.FirstOrDefault();
			model.AboutUsItems= _context.aboutUsItems.ToList();
			return View(model);
        }

    }
}
