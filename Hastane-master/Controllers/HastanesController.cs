using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HastanesController : Controller
    {
        private RandevuEntities db = new RandevuEntities();

        // GET: Hastanes
        public ActionResult Admin_Panel()
        {
            return View(db.Hastanes.ToList());
        }

        // GET: Hastanes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hastane hastane = db.Hastanes.Find(id);
            if (hastane == null)
            {
                return HttpNotFound();
            }
            return View(hastane);
        }

        // GET: Hastanes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hastanes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerID,FirstName,LastName,Date,Telefon,Text,Mail")] Hastane hastane)
        {
            if (ModelState.IsValid)
            {
                db.Hastanes.Add(hastane);
                db.SaveChanges();
                return View("~/Views/Home/index.cshtml");
            }

            return View(hastane);
        }

        // GET: Hastanes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hastane hastane = db.Hastanes.Find(id);
            if (hastane == null)
            {
                return HttpNotFound();
            }
            return View(hastane);
        }

        // POST: Hastanes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerID,FirstName,LastName,Date,Telefon,Text,Mail")] Hastane hastane)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hastane).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Admin_Panel");
            }
            return View(hastane);
        }

        // GET: Hastanes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Hastane hastane = db.Hastanes.Find(id);
            if (hastane == null)
            {
                return HttpNotFound();
            }
            return View(hastane);
        }

        // POST: Hastanes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Hastane hastane = db.Hastanes.Find(id);
            db.Hastanes.Remove(hastane);
            db.SaveChanges();
            return RedirectToAction("Admin_Panel");
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
