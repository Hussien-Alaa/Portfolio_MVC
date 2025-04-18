namespace final23.Models
{
    public class AboutViewModel
    {
        public string Name { get; set; }
        public string ProfileImagePath { get; set; }
        public string Bio { get; set; }
        public ExperienceInfo Experience { get; set; }
        public EducationInfo Education { get; set; }
    }

    public class ExperienceInfo
    {
        public string IconPath { get; set; }
        public string Title { get; set; }
        public string Years { get; set; }
        public List<string> Descriptions { get; set; }
    }

    public class EducationInfo
    {
        public string IconPath { get; set; }
        public string Title { get; set; }
        public List<string> Institutions { get; set; }
    }

}
