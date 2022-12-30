using Microsoft.AspNetCore.Mvc;
using MvcProje.Models.Entity;
using MvcProje.Repositories;

namespace MvcProje.Controllers
{
    public class AnimalController : Controller
    {
        GenericRepository<Animal> repository = new GenericRepository<Animal>(); 
        public IActionResult Index()
        {
            var animals = repository.List();
            return View(animals);
        }
    }
}
