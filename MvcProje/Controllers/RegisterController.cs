using Microsoft.AspNetCore.Mvc;
using MvcProje.Models.Entity;
using MvcProje.Repositories;
using NuGet.Protocol.Core.Types;

namespace MvcProje.Controllers
{
	public class RegisterController : Controller
	{
        GenericRepository<User> repository = new GenericRepository<User>();
        [HttpGet]
		public IActionResult AddRegister()
		{
			return View();
		}
        [HttpPost]
        public IActionResult AddRegister(User p)
        {
            p.UserStatus = true;
            p.UserImage = "-";
            repository.TAdd(p);
            return RedirectToAction("Index","Login"); 
        }
    }
}
