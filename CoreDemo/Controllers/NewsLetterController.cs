using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class NewsLetterController : Controller
    {

        NewsLetterManager nm = new NewsLetterManager(new EfNewsLetterRepository());


        [HttpGet]
        public PartialViewResult Subscribe()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Subscribe(NewsLetter newsLetter)
        {

            newsLetter.MailStatus = true;
            nm.AddNewsLetter(newsLetter);
            return PartialView();
        }


    }
}
