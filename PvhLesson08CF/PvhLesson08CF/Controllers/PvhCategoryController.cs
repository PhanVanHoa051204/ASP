using PvhLesson08CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PvhLesson08CF.Controllers
{
    public class PvhCategoryController : Controller
    {
        private static PvhBookStore _PvhbookStore;
        public PvhCategoryController() 
        {
            _PvhbookStore = new PvhBookStore();
        }
        // GET: PvhCategory
        public ActionResult PvhIndex()
        {
            var PvhCategory = _PvhbookStore.PvhCategories.ToList();
            return View(PvhCategory);
        }
        [HttpGet]
        public ActionResult PvhCreate()
        {
            var PvhCategory = new PvhCategory();
            return View(PvhCategory);
        }
        [HttpPost]
        public ActionResult PvhCreate(PvhCategory PvhCategory)
        {
            _PvhbookStore.PvhCategories.Add(PvhCategory);
            _PvhbookStore.SaveChanges();
            return View(PvhCategory);
        }
    }
}