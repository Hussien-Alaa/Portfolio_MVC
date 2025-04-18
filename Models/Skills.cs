namespace final23.Models
{
    public class Skills
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Level { get; set; }
      
        public string Category { get; set; }

    }
    public class SkillsViewModel
    {
        public List<Skills> FrontendSkills { get; set; }
        public List<Skills> BackendSkills { get; set; }
    }
}
