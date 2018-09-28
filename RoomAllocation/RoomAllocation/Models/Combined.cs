using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RoomAllocation.Models
{
    public class Combined
    {
        public User User { get; set; }
        public Room Room { get; set; }
        public Allocate Allocate { get; set; }
    }
}