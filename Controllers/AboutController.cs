using final23.Models;
using Microsoft.AspNetCore.Mvc;

namespace final23.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult Index()
        {
            var aboutModel = new AboutViewModel
            {
                Name = "Hussein Alaa",
               
                Bio = "Hello! My name is Hussein Alaa, and I am a dedicated student at the Faculty of Engineering, Tanta University, where I am majoring in Mechatronics. At just twenty years old, I have already developed a strong passion for web development. With hands-on experience in creating dynamic web applications, I am eager to enhance my skills and knowledge in the field of web programming. I am committed to continuous learning and growth, and I look forward to contributing to innovative projects that make a difference.\r\n\r\n",

                Experience = new ExperienceInfo
                {
                 
                    Title = "Experience",
                    Years = "1+ years",
                    Descriptions = new List<string> { "Web Development" , "Software Engineering" }
                },

                Education = new EducationInfo
                {
                  
                    Title = "Education",
                    Institutions = new List<string>
                    {
                        "Faculty of Engineering Tanta University", "Trainee in the Egypt Digital Pioneers Initiative"

                    }
                }
            };

            return View(aboutModel);
        }
    }
}
