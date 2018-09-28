using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EventCreation;

namespace EventCreation.Controllers
{
    public class CrudTablesController : Controller
    {
        private CreateEventModel db = new CreateEventModel();

        // GET: CrudTables
        public ActionResult Index()
        {
            return View(db.CrudTables.ToList());
        }

        // GET: CrudTables/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CrudTable crudTable = db.CrudTables.Find(id);
            if (crudTable == null)
            {
                return HttpNotFound();
            }
            return View(crudTable);
        }

        // GET: CrudTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CrudTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Title,Date_and_Time,Duration,Description,Location")] CrudTable crudTable)
        {
            if (ModelState.IsValid)
            {
                db.CrudTables.Add(crudTable);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(crudTable);
        }

        // GET: CrudTables/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CrudTable crudTable = db.CrudTables.Find(id);
            if (crudTable == null)
            {
                return HttpNotFound();
            }
            return View(crudTable);
        }

        // POST: CrudTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Title,Date_and_Time,Duration,Description,Location")] CrudTable crudTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(crudTable).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(crudTable);
        }

        // GET: CrudTables/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CrudTable crudTable = db.CrudTables.Find(id);
            if (crudTable == null)
            {
                return HttpNotFound();
            }
            return View(crudTable);
        }

        // POST: CrudTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CrudTable crudTable = db.CrudTables.Find(id);
            db.CrudTables.Remove(crudTable);
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
