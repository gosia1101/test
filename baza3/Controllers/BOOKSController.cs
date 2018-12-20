using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using baza3.Models;

namespace baza3.Controllers
{
    public class BOOKSController : Controller
    {
        private Entities db = new Entities();
        //GITHUB
        // GET: BOOKS
        public ActionResult Index()
        {
            var bOOKS = db.BOOKS.Include(b => b.CATEGORIES).Include(b => b.PUBLISHERS);
            return View(bOOKS.ToList());
        }

        // GET: BOOKS/Details/5
        public ActionResult Details(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOOKS bOOKS = db.BOOKS.Find(id);
            if (bOOKS == null)
            {
                return HttpNotFound();
            }
            return View(bOOKS);
        }

        // GET: BOOKS/Create
        public ActionResult Create()
        {
            ViewBag.CATEGORIES_ID = new SelectList(db.CATEGORIES, "ID", "TITLE");
            ViewBag.PUBLISHERS_ID = new SelectList(db.PUBLISHERS, "ID", "NAME");
            return View();
        }

        // POST: BOOKS/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,TITLE,ISBN,CATEGORIES_ID,PUBLISHERS_ID")] BOOKS bOOKS)
        {
            if (ModelState.IsValid)
            {
                db.BOOKS.Add(bOOKS);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CATEGORIES_ID = new SelectList(db.CATEGORIES, "ID", "TITLE", bOOKS.CATEGORIES_ID);
            ViewBag.PUBLISHERS_ID = new SelectList(db.PUBLISHERS, "ID", "NAME", bOOKS.PUBLISHERS_ID);
            return View(bOOKS);
        }

        // GET: BOOKS/Edit/5
        public ActionResult Edit(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOOKS bOOKS = db.BOOKS.Find(id);
            if (bOOKS == null)
            {
                return HttpNotFound();
            }
            ViewBag.CATEGORIES_ID = new SelectList(db.CATEGORIES, "ID", "TITLE", bOOKS.CATEGORIES_ID);
            ViewBag.PUBLISHERS_ID = new SelectList(db.PUBLISHERS, "ID", "NAME", bOOKS.PUBLISHERS_ID);
            return View(bOOKS);
        }

        // POST: BOOKS/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,TITLE,ISBN,CATEGORIES_ID,PUBLISHERS_ID")] BOOKS bOOKS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bOOKS).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CATEGORIES_ID = new SelectList(db.CATEGORIES, "ID", "TITLE", bOOKS.CATEGORIES_ID);
            ViewBag.PUBLISHERS_ID = new SelectList(db.PUBLISHERS, "ID", "NAME", bOOKS.PUBLISHERS_ID);
            return View(bOOKS);
        }

        // GET: BOOKS/Delete/5
        public ActionResult Delete(decimal id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BOOKS bOOKS = db.BOOKS.Find(id);
            if (bOOKS == null)
            {
                return HttpNotFound();
            }
            return View(bOOKS);
        }

        // POST: BOOKS/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(decimal id)
        {
            BOOKS bOOKS = db.BOOKS.Find(id);
            db.BOOKS.Remove(bOOKS);
            db.SaveChanges();
            return RedirectToAction("Index");
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
