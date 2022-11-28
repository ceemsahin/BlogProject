using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {

        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void AddBlog(Blog blog)
        {
            _blogDal.Insert(blog);
        }

        public void DeleteBlog(Blog blog)
        {
            _blogDal.Delete(blog);
        }

        public List<Blog> GetAllBlog()
        {
            return _blogDal.GetAll();
        }

        public Blog GetBlogById(int id)
        {
            return _blogDal.GetById(id);
        }

        public List<Blog> GetBlogListById(int id)
        {
            return _blogDal.GetAll(x => x.BlogId == id);
        }



        public List<Blog> GetBlogListWithCategory()
        {
           return _blogDal.GetListWithCategory();
        }

        public void UpdateBlog(Blog blog)
        {
            _blogDal.Update(blog);
        }
    }
}
