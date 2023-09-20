using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PsychologyProject.Business.Abstract;
using PsychologyProject.DataAccess.Concrete;
using PsychologyProject.Entities.Concrete;

namespace PsychologyProject.Cms.Controllers
{
    
    public class ContactPage : Controller
    {
        private readonly IContactService _contactService;
        private readonly DataContext _context;
        public ContactPage(IContactService contactService, DataContext context)
        {
            _contactService = contactService;
            _context = context;
        }
        public IActionResult Index()
        {
            var values = _context.contacts.FirstOrDefault();
            return View(values);
        }

        [HttpPost]
        public IActionResult Update(Contact contact)
        {
            if (contact == null)
            {
                // Eğer gelen veriler hatalı ise veya null ise uygun bir şekilde işlem yapabilirsiniz.
                return BadRequest("Güncelleme için gerekli veriler eksik veya hatalı.");
            }

            var hasContact = _context.contacts.FirstOrDefault(contact => contact.Id == contact.Id);

            if (hasContact == null)
            {
                throw new Exception($"Bu id sahip ürün bulunmamakta");
            }

            // Güncelleme işlemleri

            hasContact.Subject = contact.Subject;
            hasContact.BusinessHour= contact.BusinessHour;
            hasContact.FullName= contact.FullName;
            hasContact.Phone= contact.Phone;
            hasContact.Email= contact.Email;
            hasContact.Address= contact.Address;
            hasContact.Description= contact.Description;
            hasContact.EmailAddress= contact.EmailAddress;
            hasContact.MapKey= contact.MapKey;
            hasContact.Message= contact.Message;
          

            _context.Update(hasContact);
            _context.SaveChanges();

            // Güncelleme işlemi tamamlandıktan sonra belirli bir sayfaya yönlendirme yapabilirsiniz.
            return RedirectToAction("Index");
        }

    }
}
