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
    public class ContentManager : IContentService
    {
        IContactDal _contentDal;

        public ContentManager(IContactDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void AddContent(Content content)
        {
            throw new NotImplementedException();
        }

        public void DeleteContent(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteContent(Content category)
        {
            throw new NotImplementedException();
        }

        public Content GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Content> GetListByID(int id)
        {
            throw new NotImplementedException();
            //return _contentDal.List(x => x.HeadingID == id);
        }

        public void UpdateContent(Content category)
        {
            throw new NotImplementedException();
        }
    }
}
