using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EventsDropdown.Models
{
    public class EventContext : DbContext
    {
        public EventContext() : base("name=EventContext")
        {
        }
        public DbSet<Event> events {get;set;}
    }
}