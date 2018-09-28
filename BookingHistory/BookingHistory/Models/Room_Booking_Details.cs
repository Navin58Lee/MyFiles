using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookingHistory.Models
{
    public class Room_Booking_Details
    {

        [Key]
        public int RoomBooking_Id { get; set; }
        [ForeignKey("Room_Details")]
        public int Room_Id { get; set; }
        public Room_Details Room_Details { get; set; }
        [ForeignKey("Booking")]
        public int Booking_Id { get; set; }
        public Booking Booking { get; set; }

        [ForeignKey("User_Details")]
        public int User_Id { get; set; }
        public User_Details User_Details { get; set; }
        public DateTime Booking_Date { get; set; }
    }
}