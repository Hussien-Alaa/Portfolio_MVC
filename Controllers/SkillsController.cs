using final23.Models;
using Microsoft.AspNetCore.Mvc;

namespace final23.Controllers
{
    public class skillsController : Controller
    {
        public IActionResult Index()
        {
            var skillsViewModel = new SkillsViewModel
            {
                FrontendSkills = new List<Skills>
                {
                    new Skills { Id = 1, Name = "HTML", Level = "Experienced",  Category = "Frontend" },
                    new Skills { Id = 2, Name = "CSS", Level = "Experienced", Category = "Frontend" },
                    new Skills{ Id = 3, Name = "JavaScript", Level = "Intermediate",  Category = "Frontend" },
                     new Skills{ Id = 4, Name = "REACT", Level = "Intermediate", Category = "Frontend" }
                },

                BackendSkills = new List<Skills>
                {
                    new Skills { Id = 4, Name = "SQL", Level = "Intermediate", Category = "Backend" },
                    new Skills { Id = 5, Name = "C#", Level = "Intermediate",  Category = "Backend" },
                    new Skills { Id = 6, Name = "ASP.NET MVC", Level = "Intermediate",Category = "Backend" },
                    new Skills { Id = 7, Name = "EF core", Level = "Intermediate", Category = "Backend" } ,
                   
                }
            };

            return View(skillsViewModel);
        }
    }
}
