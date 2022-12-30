using Microsoft.AspNetCore.Mvc;

namespace MvcProje.Controllers
{
	public class CommentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
