using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCAssignment2;
using MVCAssignment2.Models;

namespace MVCAssignment2.Controllers
{
    public class CreateEventsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: CreateEvents
        public ActionResult Index()
        {
            return View(db.CreateEvents.ToList());
        }

        // GET: CreateEvents/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreateEvent createEvent = db.CreateEvents.Find(id);
            if (createEvent == null)
            {
                return HttpNotFound();
            }
            return View(createEvent);
        }

        // GET: CreateEvents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CreateEvents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Title,Date_and_Time,Duration,Description,Location")] CreateEvent createEvent)
        {
            if (ModelState.IsValid)
            {
                db.CreateEvents.Add(createEvent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(createEvent);
        }

        // GET: CreateEvents/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreateEvent createEvent = db.CreateEvents.Find(id);
            if (createEvent == null)
            {
                return HttpNotFound();
            }
            return View(createEvent);
        }

        // POST: CreateEvents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Title,Date_and_Time,Duration,Description,Location")] CreateEvent createEvent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(createEvent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(createEvent);
        }

        // GET: CreateEvents/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CreateEvent createEvent = db.CreateEvents.Find(id);
            if (createEvent == null)
            {
                return HttpNotFound();
            }
            return View(createEvent);
        }

        // POST: CreateEvents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CreateEvent createEvent = db.CreateEvents.Find(id);
            db.CreateEvents.Remove(createEvent);
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
