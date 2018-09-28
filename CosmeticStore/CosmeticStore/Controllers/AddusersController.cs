using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CosmeticStore.Models;

namespace CosmeticStore.Controllers
{
    public class AddusersController : Controller
    {
        private CosmeticContext db = new CosmeticContext();

        // GET: Addusers
        public ActionResult Index()
        {
            return View(db.Adduser.ToList());
        }

        // GET: Addusers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adduser adduser = db.Adduser.Find(id);
            if (adduser == null)
            {
                return HttpNotFound();
            }
            return View(adduser);
        }

        // GET: Addusers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Addusers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "uid,Name,Location")] Adduser adduser)
        {
            if (ModelState.IsValid)
            {
                db.Adduser.Add(adduser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adduser);
        }

        // GET: Addusers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adduser adduser = db.Adduser.Find(id);
            if (adduser == null)
            {
                return HttpNotFound();
            }
            return View(adduser);
        }

        // POST: Addusers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "uid,Name,Location")] Adduser adduser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adduser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adduser);
        }

        // GET: Addusers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adduser adduser = db.Adduser.Find(id);
            if (adduser == null)
            {
                return HttpNotFound();
            }
            return View(adduser);
        }

        // POST: Addusers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Adduser adduser = db.Adduser.Find(id);
            db.Adduser.Remove(adduser);
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
