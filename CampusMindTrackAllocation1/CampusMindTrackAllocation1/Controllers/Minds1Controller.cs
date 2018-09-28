using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CampusMindTrackAllocation1;

namespace CampusMindTrackAllocation1.Controllers
{
    public class Minds1Controller : Controller
    {
        private CampusMindsEntities db = new CampusMindsEntities();

        // GET: Minds1
        public ActionResult Index()
        {
            return View(db.Minds.ToList());
        }

        // GET: Minds1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mind mind = db.Minds.Find(id);
            if (mind == null)
            {
                return HttpNotFound();
            }
            return View(mind);
        }

        // GET: Minds1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Minds1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MID,Name,Gender,ContactNumber,TrackId")] Mind mind)
        {
            if (ModelState.IsValid)
            {
                db.Minds.Add(mind);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mind);
        }

        // GET: Minds1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mind mind = db.Minds.Find(id);
            if (mind == null)
            {
                return HttpNotFound();
            }
            return View(mind);
        }

        // POST: Minds1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MID,Name,Gender,ContactNumber,TrackId")] Mind mind)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mind).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mind);
        }

        // GET: Minds1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mind mind = db.Minds.Find(id);
            if (mind == null)
            {
                return HttpNotFound();
            }
            return View(mind);
        }

        // POST: Minds1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Mind mind = db.Minds.Find(id);
            db.Minds.Remove(mind);
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
