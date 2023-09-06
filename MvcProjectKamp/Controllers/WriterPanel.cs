using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectKamp.Controllers
{
    public class WriterPanel : Controller
    {
        // GET: WriterPanel
        public ActionResult WriterProfile()
        {
            return View();
        }
        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        [AllowAnonymous]
        public ActionResult MyHeading ()
        {
            
            var values = headingManager.GetListByWriter();
            return View(values);
        }
    }
} 