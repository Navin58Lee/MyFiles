using EventsDropdown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EventsDropdown.Controllers
{
    public class EventController : ApiController
    {
        private readonly EventContext db = new EventContext();
        [HttpPost]
        public IHttpActionResult PostDetails(Event eventobj)
        {
            db.events.Add(eventobj);
            db.SaveChanges();
            return Ok(eventobj);
        }

        [HttpGet]

        public List<Event> GetDetails()
        {
            var result = db.events.Select(x => x).ToList<Event>();
            return result;
        }

    }
}
