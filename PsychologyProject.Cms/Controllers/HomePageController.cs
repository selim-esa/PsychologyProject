using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using PsychologyProject.Business.Abstract;
using PsychologyProject.DataAccess.Concrete;
using PsychologyProject.Entities.Concrete;

namespace PsychologyProject.Cms.Controllers;

[Authorize]
public class HomePageController : Controller
{       
    private readonly IHomeService _homeService;  
    private readonly DataContext _context;
    public HomePageController(IHomeService homeService , DataContext context)
    {
         _homeService= homeService;
        _context = context;
    }
    [HttpGet]
    public IActionResult Index()
    {

        var values = _context.briefs.FirstOrDefault();
        return View(values);
    }


    [HttpPost]
    public IActionResult Update(Brief brief)
    {
        if (brief == null)
        {
            // Eğer gelen veriler hatalı ise veya null ise uygun bir şekilde işlem yapabilirsiniz.
            return BadRequest("Güncelleme için gerekli veriler eksik veya hatalı.");
        }

        var hasBrief = _context.briefs.FirstOrDefault(brief => brief.Id == brief.Id);

        if (hasBrief == null)
        {
            throw new Exception($"Bu id sahip ürün bulunmamakta");
        }

        // Güncelleme işlemleri
        hasBrief.Name = brief.Name;
        hasBrief.Description = brief.Description;
        hasBrief.Icon = brief.Icon;

        _context.Update(hasBrief);
        _context.SaveChanges();

        // Güncelleme işlemi tamamlandıktan sonra belirli bir sayfaya yönlendirme yapabilirsiniz.
        return RedirectToAction("Index");
    }



}
