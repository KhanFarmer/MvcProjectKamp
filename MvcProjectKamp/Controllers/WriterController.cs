using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntitiyFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectKamp.Controllers
{
    public class WriterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterDal());
        ContentManager contentManager = new ContentManager(new EfContentDal());
        WriterValidator validationRules = new WriterValidator();
        // GET: Writer
        public ActionResult Index()
        {
            var WriterValues = writerManager.GetList();
            return View(WriterValues);

        }
        public ActionResult Titles(int id)
        {
            var WriterValues = writerManager.GetByID(id);
            ViewData["Contents"] = contentManager.GetList();
            return View(WriterValues);
        }
        [HttpGet]
        public ActionResult AddWriter()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddWriter(Writer writer)
        {

            ValidationResult results = validationRules.Validate(writer);
            if (results.IsValid)
            {
                writerManager.AddWriter(writer);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }
            return View();
        }
        [HttpGet]
        public ActionResult EditWriter(int id)
        {
            var writervalue = writerManager.GetByID(id);
            return View(writervalue);
        }
        [HttpPost]
        public ActionResult EditWriter(Writer writer)
        {

            writerManager.UpgradeWriter(writer);
            return RedirectToAction("Index");
        }
        // var dbRecord = headingManager.GetById(heading.HeadigID);
        //dbRecord.HeadingName = heading.HeadingName;
        //  dbRecord.CategoryID = heading.CategoryID;
    }
}
