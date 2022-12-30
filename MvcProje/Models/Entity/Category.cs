using System.ComponentModel.DataAnnotations;

namespace MvcProje.Models.Entity
{
    public class Category
    {
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public bool CategoryStatus { get; set; }

        public List<Animal> Animals { get; set; }

    }
}
