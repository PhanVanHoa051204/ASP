using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PvhLesson08CF.Models;

namespace PvhLesson08CF.Controllers
{
    public class PvhbooksController : Controller
    {
        private PvhBookStore db = new PvhBookStore();

        // GET: Pvhbooks
        public ActionResult PvhIndex()
        {
            return View(db.PvhBooks.ToList());
        }

        // GET: Pvhbooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pvhbook Pvhbook = db.PvhBooks.Find(id);
            if (Pvhbook == null)
            {
                return HttpNotFound();
            }
            return View(Pvhbook);
        }

        // GET: Pvhbooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pvhbooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PvhbookId,PvhTitle,PvhAuthor,PvhYear,PvhPicture,PvhCategoryId")] Pvhbook Pvhbook)
        {
            if (ModelState.IsValid)
            {
                db.PvhBooks.Add(Pvhbook);
                db.SaveChanges();
                return RedirectToAction("PvhIndex");
            }

            return View(Pvhbook);
        }

        // GET: Pvhbooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pvhbook Pvhbook = db.PvhBooks.Find(id);
            if (Pvhbook == null)
            {
                return HttpNotFound();
            }
            return View(Pvhbook);
        }

        // POST: Pvhbooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PvhbookId,PvhTitle,PvhAuthor,PvhYear,PvhPicture,PvhCategoryId")] Pvhbook Pvhbook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Pvhbook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("PvhIndex");
            }
            return View(Pvhbook);
        }

        // GET: Pvhbooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pvhbook Pvhbook = db.PvhBooks.Find(id);
            if (Pvhbook == null)
            {
                return HttpNotFound();
            }
            return View(Pvhbook);
        }

        // POST: Pvhbooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pvhbook Pvhbook = db.PvhBooks.Find(id);
            db.PvhBooks.Remove(Pvhbook);
            db.SaveChanges();
            return RedirectToAction("PvhIndex");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
