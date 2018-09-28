using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookingHistory.Models
{
    public class Booking
    {
        [Key]
        public int Booking_Id { get; set; }
        public DateTime Booking_Date { get; set; }
        public DateTime CheckIn_Date { get; set; }
        public DateTime Checkout_Date { get; set; }
        public int Booking_Amount { get; set; }
        public int Discount_Amount { get; set; }
    }
}