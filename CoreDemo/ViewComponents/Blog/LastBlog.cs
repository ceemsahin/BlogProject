using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Blog
{
    public class LastBlog:ViewComponent
    {

        BlogManager bm = new BlogManager(new EfBlogRepository());


        public IViewComponentResult Invoke()
        {

            var values = bm.GetLastBlog();
            return View(values);
        }



    }
}
