using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository _efCategoryRepository;

        public CategoryManager(EfCategoryRepository efCategoryRepository)
        {
            _efCategoryRepository = efCategoryRepository;
        }

        public void AddCategory(Category category)
        {
          _efCategoryRepository.Insert(category);
        }

        public List<Category> GetAllCategory()
        {
            return _efCategoryRepository.GetAll();  
        }

        public Category GetCategoryById(int id)
        {
           return _efCategoryRepository.GetById(id);
        }

        public void RemoveCategory(Category category)
        {
            _efCategoryRepository.Delete(category);
        }

        public void UpdateCategory(Category category)
        {
             _efCategoryRepository.Update(category);
        }
    }
}
