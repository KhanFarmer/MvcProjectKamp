using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        List<Content> GetListByID(int id);
        void AddContent(Content content);
        Content GetByID(int id);
        void DeleteContent(int id);
        void DeleteContent(Content category);
        void UpdateContent(Content category);
    }
}
