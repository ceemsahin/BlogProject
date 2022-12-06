using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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

        [HttpGet]
        public PartialViewResult AddCommentPartial()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult AddCommentPartial(Comment comment)
        {
            comment.CommentDate=DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.CommentStatus = true;
            comment.BlogId = 5;
            cm.AddComment(comment);
            return PartialView();
        }
        public PartialViewResult CommentListByBlog(int id)
        {
          
            var values=cm.GetAllComment(id);
            return PartialView(values);
        }

        

    }



}
