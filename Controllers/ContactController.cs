using final23.Models;
using Microsoft.AspNetCore.Mvc;

namespace final23.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            var contacts = new List<Contact>
    {
        new Contact
        {
            Email = "hussien.alaaraafat@gmail.com",
            
            LinkedInUrl = "https://www.linkedin.com/in/hussien-alaa-75ab54320",
          
        }
    };
            return View(contacts);
        }
    }
}
