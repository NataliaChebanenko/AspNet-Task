using AspNet_Task.Web.Data;
using AspNet_Task.Web.Data.Models;
using AspNet_Task.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet_Task.Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public ContactController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var model = new ContactFormModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Submit(ContactFormModel contact)
        {
                var contactFormEntry = new Contact
                {
                    Name = contact.Name,
                    Email = contact.Email,
                    Subject = contact.Subject,
                    Message = contact.Message
                };

            _dbContext.Contacts.Add(contactFormEntry);

            _dbContext.SaveChanges();


            return RedirectToAction("ThankYou");
        }

        public IActionResult ThankYou()
        {
            return View();
        }
    }
}
