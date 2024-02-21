namespace red_social.Models
{
    public class User
    {
        public int Id { get; set; }
        public int NameUser { get; set; }
        public int Password { get; set; }
        public int Email { get; set; }
        public List<Project> Projects { get; set; }

    }
}
