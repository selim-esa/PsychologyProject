using Microsoft.AspNetCore.Mvc;
using PsychologyProject.Business.Abstract;
using PsychologyProject.DataAccess.Concrete;
using PsychologyProject.Entities.Concrete;
using PsychologyProject.Web.ViewModel;

namespace PsychologyProject.Web.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IServiceService _serviceService;
        private readonly DataContext _context;

        public ServicesController(IServiceService serviceService, DataContext context)
        {
            _serviceService = serviceService;
            _context = context;
        }

        public IActionResult Index()
        {
			ServiceViewModel model = new ServiceViewModel();
            model.Service = _context.services.FirstOrDefault();
            model.serviceItem = _context.serviceItem.ToList();
			return View(model);

			
        }
    }
}
