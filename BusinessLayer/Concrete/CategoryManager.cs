using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICatagoryService
    {
        ICategoryDal _categoryDal;
        

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddCategory(Category category)
        {
            _categoryDal.Insert(category);
        }

        public void DeleteCategory(Category category)
        {
            _categoryDal.Delete(category);    
        }

        public void DeleteCategory(int id)
        {
            _categoryDal.Delete(GetByID(id));    
        }

        public Category GetByID(int id)
        {
            return _categoryDal.get(x=>x.CategoryID == id);
        }

        public List<Category> GetList()
        {
            return _categoryDal.List();
        }

        public void UpdateCategory(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
