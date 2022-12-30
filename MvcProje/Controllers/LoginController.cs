using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MvcProje.Data;
using MvcProje.Models.Entity;
using System.Security.Claims;
using System.Threading.Tasks;


namespace MvcProje.Controllers
{
    public class LoginController : Controller
    {
        //get login
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        //[AllowAnonymous]
        //public async Task<IActionResult> Index(User p)
        public IActionResult Index(User p)
        {
            //Context c = new Context();
            //var dataValue = c.Users.FirstOrDefault(x => x.UserMail == p.UserMail && x.UserPassword == p.UserPassword);
            //if (dataValue != null)
            //{
            //    var claims = new List<Claim>
            //    {
            //        new Claim(ClaimTypes.Name,p.UserMail)
            //    };
            //    var userIdentitiy = new ClaimsIdentity(claims, "a");
            //    ClaimsPrincipal principal = new ClaimsPrincipal(userIdentitiy);
            //    await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Admin");
            //}
            //else
            //{
            //    return View();
            //}
        }
    }
}
