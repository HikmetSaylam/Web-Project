using Microsoft.AspNetCore.Mvc;
using MvcProje.Models.Entity;
using MvcProje.Repositories;

namespace MvcProje.Controllers
{
	public class CategoryController : Controller
	{
        GenericRepository<Category> repository = new GenericRepository<Category>();
        public IActionResult Index()
		{
			var categories = repository.List();

			return View(categories);
		}
	}
}
