using final23.Models;
using Microsoft.AspNetCore.Mvc;

namespace final23.Controllers
{
    public class ProjectsController : Controller
    {
        private List<Project> GetProjects()
        {
            return new List<Project>
        {
            new Project
            {
                Id = 1,
                Title = "WEATHER APP",
                Category = "Web App",
                ImageUrl = "/images/project1.png",
                BackgroundImageUrl = "/images/weather-bg.jpg",
                ProjectUrl = "/Projects/Details/1",
               description =  "Weather forecasting app using HTML, CSS, JavaScript, API"
            },
            new Project
            {
                Id = 2,
                Title = "built a portfolio",
                Category = "Web app",
                ImageUrl = "/images/project2.png",
                BackgroundImageUrl = "/images/portfolio-bg.jpg",
                ProjectUrl = "/Projects/Details/2",
             description =  "a portfolio Web app Built using ASP.NET MVC  "
            },
            new Project
            {
                Id = 3,
                Title = "Library management system",
                Category = "Back end",
                ImageUrl = "/images/project3.png",
                BackgroundImageUrl = "/images/library-bg.jpg",
                ProjectUrl = "/Projects/Details/3",
                description =  "Library management system Built using C# and OOP"
            }
        };
        }

        public ActionResult Index()
        {
            var projects = GetProjects();
            return View(projects);
        }

        public ActionResult Details(int id)
        {
            var project = GetProjects().FirstOrDefault(p => p.Id == id);
            if (project == null)
            {
                return NotFound();
            }
            return View(project);
        }

        public ActionResult All()
        {
            var projects = GetProjects();
            return View(projects);
        }
    }
}