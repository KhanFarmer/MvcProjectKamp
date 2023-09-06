﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> GetList();
        List<Heading> GetListByWriter();
        void AddHeading(Heading heading);
        Heading GetById(int id);
        void DeleteHeading(Heading heading);
        void UpdateHeading(Heading heading);

    }
}
