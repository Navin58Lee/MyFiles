using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EventsDropdown.Models
{
    public class Event
    {
        [Key]
        public int eventId { get; set; }
        public string eventName { get; set; }
        public string participantName { get; set; }
    }
}