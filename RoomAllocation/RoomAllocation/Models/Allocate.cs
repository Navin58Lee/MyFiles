using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RoomAllocation.Models
{
    public class Allocate
    {
        [Key]
        public int Aid { get; set; }
        [ForeignKey("User")]
        public int Uid { get; set; }
        public User User { get; set; }
        [ForeignKey("Room")]
        public int RoomId { get; set; }
        public Room Room { get; set; }

    }
}