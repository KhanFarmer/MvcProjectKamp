using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICatagoryService
    {
        List<Category> GetList();
        void AddCategory(Category category);
        Category GetByID(int id);  
        void DeleteCategory(int id);
        void DeleteCategory(Category category);
        void UpdateCategory(Category category);
    }
}
