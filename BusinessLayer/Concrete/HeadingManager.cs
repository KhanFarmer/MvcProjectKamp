﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }

        public void AddHeading(Heading heading)
        {
            _headingDal.Insert(heading);
        }

        public void DeleteHeading(Heading heading)
        {
            
           _headingDal.Update(heading);
        }
         
        public Heading GetById(int id)
        {
            return _headingDal.get(x =>x.HeadigID == id);
        }

        public List<Heading> GetList()
        {
            return _headingDal.List();
        }

        public List<Heading> GetListByWriter()
        {
            return _headingDal.List(x=>x.WriterID == 3);
        }

        public void UpdateHeading(Heading heading)
        {
            heading.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            _headingDal.Update(heading);
        }
    }
}
