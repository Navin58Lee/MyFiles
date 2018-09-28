using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjectDemoLatest.Models
{
    public class Room_Booking_Details
    {
        [Key]
        public int RoomBooking_Id { get; set; }
        [ForeignKey("Room_Details")]
        public int Room_Id { get;set; }
        public Room_Details Room_Details { get; set; }
        [ForeignKey("Booking")]
        public int Booking_Id { get; set; }
        public Booking Booking { get; set; }
    }
}



