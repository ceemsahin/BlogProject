using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents
{
    public class CommentList:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    Id = 1,
                    UserName="Cem"
                },
                new UserComment
                {
                     Id=2,
                     UserName="Yudum"
                },
                 new UserComment
                {
                     Id=3,
                     UserName="Ela"
                },
            };


            return View(commentValues);
        }


    }
}
