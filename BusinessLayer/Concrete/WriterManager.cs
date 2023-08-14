using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntitiyFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;
        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public void AddWriter(Writer writer)
        {
            _writerDal.Insert(writer);
        }

        public Writer GetByID(int id)
        {
            return _writerDal.get(x => x.WriterID == id);
        }

        public List<Writer> GetList()
        {
            return _writerDal.List();
        }
        public void RemoveWriter(Writer writer)
        {
            _writerDal.Delete(writer);
        }

        public void UpgradeWriter(Writer writer)
        {
            _writerDal.Update(writer);
        }
    }
}
