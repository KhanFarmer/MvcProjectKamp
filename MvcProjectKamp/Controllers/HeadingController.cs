using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntitiyFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectKamp.Controllers
{
    public class HeadingController : Controller
    {
        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        CategoryManager categoryManager= new CategoryManager(new EfCategoryDal());
        WriterManager writerManager= new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            var headingValues = headingManager.GetList();
            return View(headingValues);
        }
        [HttpGet]
        public ActionResult AddHeading()
        {
            List<SelectListItem> valueCategory = (from x in categoryManager .GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text=x.CategoryName,
                                                      Value=x.CategoryID.ToString(),
                                                  }).ToList();
                ViewBag.vlc = valueCategory; 

            List<SelectListItem> valueWriter = (from x in writerManager .GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text=x.WriterName + " " + x.WriterSurname,
                                                      Value=x.WriterID.ToString(),
                                                  }).ToList();
                ViewBag.vlw = valueWriter;
    
            return View();
        }
        [HttpPost]
        public ActionResult AddHeading(Heading heading)
        {
            heading.HeadingDate =DateTime.Parse(DateTime.Now.ToShortDateString());
            WriterValidator validationRules = new WriterValidator();
            headingManager.AddHeading(heading);
            return RedirectToAction("Index");
        }
        
    }
}