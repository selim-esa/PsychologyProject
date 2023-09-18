using Microsoft.AspNetCore.Mvc;
using PsychologyProject.Business.Abstract;
using PsychologyProject.DataAccess.Concrete;
using PsychologyProject.Entities.Concrete;
using PsychologyProject.Web.ViewModel;

namespace PsychologyProject.Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly DataContext _context;

        public ContactController(IContactService contactService,DataContext context)
        {
            _context = context;
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            ContactViewModel model = new ContactViewModel();
            model.Contact = _context.contacts.FirstOrDefault();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(Contact contact) 
        {
            _context.contacts.Add(contact);
            _context.SaveChanges();
            return View(contact);
        }
    }
}
