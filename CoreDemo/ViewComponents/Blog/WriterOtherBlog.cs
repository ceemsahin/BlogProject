using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Blog
{
    public class WriterOtherBlog:ViewComponent
    {

        BlogManager bm = new BlogManager(new EfBlogRepository());


        public IViewComponentResult Invoke()
        {

            var values = bm.GetBlogListByWriter(4);
            return View(values);  
        }


    }
}
