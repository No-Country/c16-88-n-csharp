using System.ComponentModel.DataAnnotations;

namespace red_social.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
    }
}
