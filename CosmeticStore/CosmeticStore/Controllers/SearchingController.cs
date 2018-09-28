using CosmeticStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CosmeticStore.Controllers
{
    public class SearchingController : Controller
    {


        CosmeticContext db = new CosmeticContext();
        // GET: Searching
        public ActionResult Index(string searching)
        {
            return View(db.Addcosmetic.Where(x => x.CosmeticName.Contains(searching) || searching == null).ToList());
        }
    }
}