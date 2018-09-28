using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Async;
using RoomAllocation.Models;
namespace RoomAllocation.Controllers
{
    public class AllocatesController : Controller
    {
        private RoomContext db = new RoomContext();

        public IEnumerable Rid { get; private set; }

        // GET: Allocates
        public ActionResult Index()
        {
            var allocate = db.Allocate.Include(a => a.Room).Include(a => a.User);
            return View(allocate.ToList());
        }

        // GET: Allocates/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Allocate allocate = db.Allocate.Find(id);
            if (allocate == null)
            {
                return HttpNotFound();
            }
            return View(allocate);
        }
        // GET: Allocates/Create
        public ActionResult Create()
        {
            /*var rooms = (from a in db.Allocate select a.RoomId).ToList();
            var urooms = (from b in db.Room where !rooms.Contains(b.RoomId) select b).ToList();*/
            //var user = (from a in db.Allocate select a.Uid).ToList();
            //var uuser = (from b in db.User where !user.Contains(b.Uid) select b).ToList();
          
            //var user = (from a in db.Allocate select a.Uid).ToList();

           // var duplicates = (user.GroupBy(txt => txt)
            //.Where(grouping => grouping.Count() > 1)).ToList();
            ViewBag.RoomId = new SelectList(db.Room, "RoomId", "Rid");
            ViewBag.Uid = new SelectList(db.User, "Uid", "MID");
            return View();
        }

        // POST: Allocates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Aid,Uid,RoomId")] Allocate allocate)
        {
            if (ModelState.IsValid)
            {
                var q = (from a in db.Allocate select a.Uid).ToList();
                var duplicate = (from a in db.Allocate group a by a.Uid into b where (b.Count() == 2) select b.Key).ToList();
                //var y = (from c in db.User where !u.Contains(c.Uid) select c.Uid).ToList();
                //foreach(var x in duplicate)
                //{
                //    if()
                //}
                if (duplicate.Count > 0)
                {
                    TempData["Message"] = "Only 2 rooms per User is allowed";
                    return RedirectToAction("Create");
                    //return Content("Only 2 rooms per User is allowed");
                }
                else
                {
                    db.Allocate.Add(allocate);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            ViewBag.RoomId = new SelectList(db.Room, "RoomId", "Rid", allocate.RoomId);
            ViewBag.Uid = new SelectList(db.User, "Uid", "MID", allocate.Uid);
            return View(allocate);
        }

        // GET: Allocates/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Allocate allocate = db.Allocate.Find(id);
            if (allocate == null)
            {
                return HttpNotFound();
            }
            ViewBag.RoomId = new SelectList(db.Room, "RoomId", "BlockName", allocate.RoomId);
            ViewBag.Uid = new SelectList(db.User, "Uid", "MID", allocate.Uid);
            return View(allocate);
        }

        // POST: Allocates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Aid,Uid,RoomId")] Allocate allocate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(allocate).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.RoomId = new SelectList(db.Room, "RoomId", "BlockName", allocate.RoomId);
            ViewBag.Uid = new SelectList(db.User, "Uid", "MID", allocate.Uid);
            return View(allocate);
        }

        // GET: Allocates/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Allocate allocate = db.Allocate.Find(id);
            if (allocate == null)
            {
                return HttpNotFound();
            }
            return View(allocate);
        }

        // POST: Allocates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Allocate allocate = db.Allocate.Find(id);
            db.Allocate.Remove(allocate);
            await db.SaveChangesAsync();
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
