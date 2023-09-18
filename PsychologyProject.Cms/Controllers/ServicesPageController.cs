using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PsychologyProject.Business.Abstract;
using PsychologyProject.Cms.Models;
using PsychologyProject.DataAccess.Concrete;
using PsychologyProject.Entities.Concrete;

namespace PsychologyProject.Cms.Controllers
{
   
    public class ServicesPageController : Controller
    {
        private readonly IServiceService _serviceService;
        private readonly DataContext _context;

        public ServicesPageController(DataContext context, IServiceService serviceService)
        {
            _context = context;
            _serviceService = serviceService;
        }

        [HttpGet]
        public IActionResult index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Service service, ServiceItem serviceItem)
        {
		
			_context.services.Add(service);  
            _context.SaveChanges();
            _context.serviceItem.Add(serviceItem);
			_context.SaveChanges();

			return View();
        }

    }
}
