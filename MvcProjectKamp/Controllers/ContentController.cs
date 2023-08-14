using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectKamp.Controllers
{
    public class ContentController : Controller
    {
        ContentManager cm = new ContentManager(new EfContentDal());
        // GET: Content
        public ActionResult Index() 
        {
            return View();
        }
        public ActionResult ContentByHeading(int id)
        {

            var contentvalues = cm.GetListByID(id);
            return View(contentvalues);
        }
    }
}