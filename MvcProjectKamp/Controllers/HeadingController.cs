﻿using BusinessLayer.Concrete;
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
        [HttpGet]
        public ActionResult EditHeading(int id)
        {
            List<SelectListItem> valueCategory = (from x in categoryManager.GetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryID.ToString(),
                                                  }).ToList();
            ViewBag.vlc = valueCategory;
            var HeadingValue = headingManager.GetById(id);
            return View(HeadingValue); 
        }
        [HttpPost]
        public ActionResult EditHeading(Heading heading)
        {
            var dbRecord = headingManager.GetById(heading.HeadigID);
            dbRecord.HeadingName = heading.HeadingName;
            dbRecord.CategoryID = heading.CategoryID;

            headingManager.UpdateHeading(dbRecord);
            return RedirectToAction("Index");
        }
        public ActionResult DeleteHeading(int id)
        {
            var HeadingValue = headingManager.GetById(id);
            HeadingValue.HeadingStatus = false;
            headingManager.DeleteHeading(HeadingValue);
            return RedirectToAction("Index");
        }
    }
}