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
            var values = _context.services.FirstOrDefault();
            var values2 = _context.services.FirstOrDefault();
            
            return View(values);
        }
        [HttpPost]
        public IActionResult Update(Service service,ServiceItem serviceItem)
        {
            if (service== null)
            {
                // Eğer gelen veriler hatalı ise veya null ise uygun bir şekilde işlem yapabilirsiniz.
                return BadRequest("Güncelleme için gerekli veriler eksik veya hatalı.");
            }

            var hasService= _context.services.FirstOrDefault(service=> service.Id == service.Id);

            if (hasService== null)
            {
                throw new Exception($"Bu id sahip ürün bulunmamakta");
            }

            // Güncelleme işlemleri
            hasService.Title = service.Title;
            hasService.Description= service.Description;
         
            
            

            _context.Update(hasService);
            _context.SaveChanges();

            var hasServiceItem = _context.serviceItem.FirstOrDefault(serviceItem => serviceItem.Id == serviceItem.Id);

            hasServiceItem.ServicesDescription = serviceItem.ServicesDescription;
            hasServiceItem.ServicesTitle = serviceItem.ServicesTitle;
            hasServiceItem.ServicesIcon = serviceItem.ServicesIcon;
            _context.Update(hasServiceItem);
            _context.SaveChanges();

            // Güncelleme işlemi tamamlandıktan sonra belirli bir sayfaya yönlendirme yapabilirsiniz.
            return RedirectToAction("Index");
        }

    }
}
