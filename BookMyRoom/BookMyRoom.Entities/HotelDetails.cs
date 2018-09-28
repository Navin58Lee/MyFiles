using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyRoom.Entities
{
        public class HotelDetails
        {
            [Key]
            public int hotelId { get; set; }
            public string hotelName { get; set; }
            public string hotelAdd { get; set; }
            public int totalRoom { get; set; }
            public int hotelRating { get; set; }
        }
}
