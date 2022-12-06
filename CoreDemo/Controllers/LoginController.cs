using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CoreDemo.Controllers
{
    public class LoginController : Controller
    {

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Index(Writer writer)
        {

            Context c = new Context();
            var datavalue = c.Writers.FirstOrDefault(x => x.WriterEmail == writer.WriterEmail && x.WriterPassword == writer.WriterPassword);
            if (datavalue != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,writer.WriterEmail)
                };

                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Writer");
            }
            else
            {
                 return View();    
            }
           

        }
    }
}
//Context c = new Context();
//var datavalue = c.Writers.FirstOrDefault(x => x.WriterEmail == writer.WriterEmail && x.WriterPassword == writer.WriterPassword);
//if (datavalue != null)
//{
//    HttpContext.Session.SetString("Username", writer.WriterEmail);
//    return RedirectToAction("Index", "Writer");
//}

//else
//{
//    return View();
//}
