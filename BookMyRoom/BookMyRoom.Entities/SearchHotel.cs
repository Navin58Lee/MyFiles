using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyRoom.Entities
{
    public class SearchHotel
    {
        [Key]
        public int searchId { get; set; }
        public string hotelName { get; set; }
        public string hotelAdd { get; set; }
        public string roomType { get; set; }
        public string cityName { get; set; }
        public string checkinDate { get; set; }
        public string checkoutDate { get; set; }
        public string roomId { get; set; }
    }
}
