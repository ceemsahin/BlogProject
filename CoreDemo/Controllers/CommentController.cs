using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {

        CommentManager cm = new CommentManager(new EfCommentRepository());


        public IActionResult Index()
        {
            return View();
        }


        public PartialViewResult AddCommentPartial()
        {
            return PartialView();
        }
        public PartialViewResult CommentListByBlog(int id)
        {
          
            var values=cm.GetAllComment(id);
            return PartialView(values);
        }

        

    }



}
