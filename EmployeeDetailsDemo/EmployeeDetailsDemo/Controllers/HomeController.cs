using EmployeeDetailsDemo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace EmployeeDetailsDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            IEnumerable<Department> ObjEmployee = null;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:50537/");
            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/Departments/GetAllDepartment").Result;
            if (response.IsSuccessStatusCode)
            {
                var EmpResponse = response.Content.ReadAsStringAsync().Result;

                //Deserializing the response recieved from web api and storing into the Employee list  
                ObjEmployee = JsonConvert.DeserializeObject<List<Department>>(EmpResponse);

            }

            return View(ObjEmployee);
        }
    }
}
