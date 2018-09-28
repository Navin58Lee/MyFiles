using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Country.Controllers
{
    public class CountryController : Controller
    {
        // GET: Country
        public ViewResult Index()
        {
            ViewBag.Countries = new List<string>()
            {
                "India",
                "Australia",
                "Japan",
                "France"
            };
            return View();
        }
    }
}