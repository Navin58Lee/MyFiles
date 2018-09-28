using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookingHistory.Models
{
    public class Room_Details
    {
        [Key]
        public int Room_Id { get; set; }
        public string Room_Type { get; set; }

        [ForeignKey("Hotel_Details")]
        public int Hot_Id { get; set; }
        public Hotel_Details Hotel_Details { get; set; }
    }
}