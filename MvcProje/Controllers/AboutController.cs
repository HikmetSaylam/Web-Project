
using Grpc.Core;
using Microsoft.AspNetCore.Mvc;
using MvcProje.Data;
using MvcProje.Models.Entity;
using MvcProje.Repositories;

namespace MvcProje.Controllers
{
	public class AboutController : Controller
	{
		Context db = new Context();

		//GenericRepository<About> repository=new GenericRepository<About>();	
		public IActionResult Index()
		{
            


            return View(db.Abouts.ToList());
		}
        public IActionResult Edit(int id)
        {
            var hakkinda = db.Abouts.Where(x => x.AboutId == id).SingleOrDefault();

            return View();
        }
       //[HttpPost]
       // [ValidateAntiForgeryToken]
       //public IActionResult Edit(int id ,About about,IFormFile AboutImage)
       //{
       //     if (ModelState.IsValid)
       //     {
       //         var a = db.Abouts.Where(x => x.AboutId == id).SingleOrDefault();
       //         if (AboutImage  != null) {
       //             var UploadPath = Server.MapPath(about.AboutImage);

       //             if (System.IO.File.Exists(UploadPath))
       //             {

       //             }
       //                 }
       //     }

       //    return View();
       //}


    }
}
