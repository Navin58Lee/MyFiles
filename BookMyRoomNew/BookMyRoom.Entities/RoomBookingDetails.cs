using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyRoom.Entities
{
    public class RoomBookingDetails
    {
      
            [Key]
            public int roomBookingId { get; set; }
            [ForeignKey("roomDetails")]
            public int roomId { get; set; }
            public RoomDetails roomDetails { get; set; }
            [ForeignKey("booking")]
            public int bookingId { get; set; }
            public Booking booking { get; set; }
        
    }
}
