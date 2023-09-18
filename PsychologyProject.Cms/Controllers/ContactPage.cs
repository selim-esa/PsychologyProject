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
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            _context.contacts.Add(contact);
            _context.SaveChanges();
            return View();
        }

    }
}
