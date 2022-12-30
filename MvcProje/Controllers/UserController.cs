using Microsoft.AspNetCore.Mvc;
using MvcProje.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcProje.Data;
using MvcProje.Models.Entity;
using MvcProje.Repositories;

namespace MvcProje.Controllers
{
    public class UserController
    {
        Context db = new Context();

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]

        //kullanıcı giriş doğrulama
        /*public ActionResult Login(User user)
        {
            var login = db.User.Where(x => x.Eposta == admin.Eposta).SingleOrDefault();
            if(login.Eposta==user.Eopsta&&login.Sifre==user.Sifre)
            {
                Session["userid"] = login.UserId;
                Session["eposta"] = login.Eposta;
                return RedirectToAction("Index", "User");
            }
            ViewBag.Uyari = "Kullanici adi veya sifre hatalidir";
            return View(user);
        }*/

        [HttpGet]
        public IActionResult AnimalAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AnimalAdd(Animal animal)
        {
            animal.AnimalStatus = true;
            animal.UserID = 15;
            repository.TAdd(animal);
            return RedirectToAction("Index"); //admin controller daki index metoduna gönderme yani yukarı
        }

        [HttpPost]
        public IActionResult AnimalUpdate(int animalId)
        {
            var update = db.Animal.Where(x => x.AnimalID == animalId).SingleOrDefault();
            if(update.AnimalID==animalId)
            {
                return View(update);
            }
            ViewBag.Uyari = "aradiginiz id'e sahip bir hayvan bulunamadi";
            return View();
        }

        [HttpPost]
        public ActionResult RemoveAnimal(Animal animal)
        {
            animal.AnimalStatus = false;
            repository.TDelete(animal);
            return RedirectToAction("Index");
        }



    }
}
