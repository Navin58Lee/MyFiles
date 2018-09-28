using CrudAssignment2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudAssignment2.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult Index()
        {

            return View();
        }
        [HttpGet]
        public ActionResult Details()
        {
            string conn = "";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            List<EventsModel> Events = new List<EventsModel>();
            if(con!=null)
            {
                string q = "Select * from Crudtable1";
                try
                {
                    SqlCommand cmd = new SqlCommand(q, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        EventsModel e = new EventsModel();
                        e.id = Convert.ToInt32(reader[0]);
                        e.name = reader[1].ToString();
                        Events.Add(e);
                    }
                    TempData["Events"] = Events;
                }
                catch (SqlException)
                {
                    Console.WriteLine("Exception Occured");
                }
                finally
                {
                    con.Close();
                }
            }
            return View();
        }
        public ActionResult CreateEvent()
        {
            return View();
        }
       [HttpPost]
        public ActionResult CreateEvent(Models.EventsModel model)
        {
            string con = "Data Source=G1C2ML18279;Initial Catalog=Crud;Integrated Security=True";
            SqlConnection c = new SqlConnection(con);
            c.Open();
            string q = "Insert into Crudtable1 values(@id,@name)";
            SqlCommand s = new SqlCommand(q, c);
            s.Parameters.AddWithValue("@id", model.id);
            s.Parameters.AddWithValue("@name", model.name);
            s.ExecuteNonQuery();
            c.Close();
            return RedirectToAction("Details", model);
        }
    }
}