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
            var values = _context.aboutUs.FirstOrDefault();
            var values2 = _context.aboutUsItems.FirstOrDefault();
            return View(values);
        }

        [HttpPost]
        public IActionResult Update(AboutUs aboutUs, AboutUsItem aboutUsItem )
        {
            if (aboutUs == null)
            {
                // Eğer gelen veriler hatalı ise veya null ise uygun bir şekilde işlem yapabilirsiniz.
                return BadRequest("Güncelleme için gerekli veriler eksik veya hatalı.");
            }

            var hasAboutUs = _context.aboutUs.FirstOrDefault(aboutUs => aboutUs.Id == aboutUs.Id);

            if (hasAboutUs == null)
            {
                throw new Exception($"Bu id sahip ürün bulunmamakta");
            }

            // Güncelleme işlemleri
            hasAboutUs.CupsOfCoffee = aboutUs.CupsOfCoffee;
            hasAboutUs.HappyClient = aboutUs.HappyClient;
            hasAboutUs.YearInBusiness= aboutUs.YearInBusiness;
            hasAboutUs.OurTeamTitle = aboutUs.OurTeamTitle;
            hasAboutUs.Description= aboutUs.Description;
            hasAboutUs.OurTeamDescription = aboutUs.OurTeamDescription;
            hasAboutUs.OurTeamPreDescription = aboutUs.OurTeamPreDescription;
            hasAboutUs.WeArePreDescription = aboutUs.WeArePreDescription;
            hasAboutUs.WeAreDescription = aboutUs.WeAreDescription;
            hasAboutUs.WeAreTitle = aboutUs.WeAreTitle; 
           
            

            _context.Update(hasAboutUs);
            _context.SaveChanges();

            var hasAboutUsItem = _context.aboutUsItems.FirstOrDefault(aboutUsItem => aboutUsItem.Id == aboutUsItem.Id);

            hasAboutUsItem.SubTitle = aboutUsItem.SubTitle;
            hasAboutUsItem.SubDescription= aboutUsItem.SubDescription;

            _context.Update(hasAboutUsItem);
            _context.SaveChanges();
            // Güncelleme işlemi tamamlandıktan sonra belirli bir sayfaya yönlendirme yapabilirsiniz.
            return RedirectToAction("Index");
        }
    }
}
