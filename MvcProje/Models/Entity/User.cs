using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace MvcProje.Models.Entity
{
    public class User
    {
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string UserSurname { get; set; }

        public string UserImage { get; set; }

        public string UserAbout { get; set; }

        public string UserMail { get; set; }

        public string UserPassword { get; set; }

        public bool UserStatus { get; set; }

        public List<Animal> Animals { get; set; }
    }
}
