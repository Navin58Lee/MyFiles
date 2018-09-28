using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RoomAllocation.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
    
        public int RID { get; set; }
       
        public string BlockName { get; set; }
       
        public string FloorNumber { get; set; }
    }
}