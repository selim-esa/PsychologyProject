using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PsychologyProject.Business.Abstract;
using PsychologyProject.DataAccess.Concrete;
using PsychologyProject.Entities.Concrete;

namespace PsychologyProject.Cms.Controllers;

[Authorize]
public class HomePageController : Controller
{       
    private readonly IHomeService _homeService;  
    private readonly DataContext _context;
    public HomePageController(IHomeService homeService , DataContext context) //telefon numaranı yazar mısın 05416419734
    {
         _homeService= homeService;
        _context = context;
    }
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Home home)
    {   
        _context.homes.Add(home);
        _context.SaveChanges();   
        return View();
    }




}
