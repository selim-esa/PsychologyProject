using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PsychologyProject.Business.Abstract;
using PsychologyProject.DataAccess.Concrete;
using PsychologyProject.Entities.Concrete;

namespace PsychologyProject.Cms.Controllers
{
    public class AboutUsPageController : Controller
    {
        private readonly IAboutUsService _aboutUsService;
        private readonly DataContext _context;

        public AboutUsPageController(DataContext context, IAboutUsService aboutUsService)
        {
            _context = context;
            _aboutUsService = aboutUsService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AboutUs aboutUs,AboutUsItem aboutUsItem)
        {
            _context.aboutUs.Add(aboutUs);
            _context.SaveChanges();

            _context.aboutUsItems.Add(aboutUsItem);
            _context.SaveChanges();
            return View();
        }
    }
}
