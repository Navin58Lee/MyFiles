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
    public class AddcosmeticsController : Controller
    {
        private CosmeticContext db = new CosmeticContext();
        [HttpGet]
        // GET: Addcosmetics
        public ActionResult Index()
        {
            ViewBag.CosmeticName = "";
            return View(db.Addcosmetic.ToList());
        }
        [HttpPost]
        public ActionResult Index(string CosmeticName)
        {
            ViewBag.CosmeticName = CosmeticName;
            var cosmetic = db.Addcosmetic.ToList().Where(X => X.CosmeticName.Contains(CosmeticName));
            return View(cosmetic);
        }
        // GET: Addcosmetics/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Addcosmetic addcosmetic = db.Addcosmetic.Find(id);
            if (addcosmetic == null)
            {
                return HttpNotFound();
            }
            return View(addcosmetic);
        }

        // GET: Addcosmetics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Addcosmetics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cid,CosmeticName,Company,Category,Quantity,Price")] Addcosmetic addcosmetic)
        {
            if (ModelState.IsValid)
            {
                db.Addcosmetic.Add(addcosmetic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(addcosmetic);
        }

        // GET: Addcosmetics/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Addcosmetic addcosmetic = db.Addcosmetic.Find(id);
            if (addcosmetic == null)
            {
                return HttpNotFound();
            }
            return View(addcosmetic);
        }

        // POST: Addcosmetics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cid,CosmeticName,Company,Category,Quantity,Price")] Addcosmetic addcosmetic)
        {
            if (ModelState.IsValid)
            {
                db.Entry(addcosmetic).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(addcosmetic);
        }

        // GET: Addcosmetics/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Addcosmetic addcosmetic = db.Addcosmetic.Find(id);
            if (addcosmetic == null)
            {
                return HttpNotFound();
            }
            return View(addcosmetic);
        }

        // POST: Addcosmetics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Addcosmetic addcosmetic = db.Addcosmetic.Find(id);
            db.Addcosmetic.Remove(addcosmetic);
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
