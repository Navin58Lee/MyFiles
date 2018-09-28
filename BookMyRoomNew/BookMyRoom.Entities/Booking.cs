using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyRoom.Entities
{
    public class Booking
    {
        [Key]
        public int bookingId { get; set; }
        public DateTime bookingDate { get; set; }
        public DateTime checkinDate { get; set; }
        public DateTime checkoutDate { get; set; }
        public int bookingAmount { get; set; }
        public int discountAmount { get; set; }
    }
}
