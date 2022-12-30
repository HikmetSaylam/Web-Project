using System.ComponentModel.DataAnnotations;

namespace MvcProje.Models.Entity
{
    public class Animal
    {
        public int AnimalID { get; set; }
        public int AnimalAge { get; set; }
        public string AnimalImage { get; set; }
        public string AnimalName { get; set; }
        public string AnimalDescription { get; set; }
        public bool AnimalStatus { get; set; }

        public int UserID { get; set; }

        public User User { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
