using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class History
    {
        public int hotelId { get; set; }
        public string hotelName { get; set; }
        public string hotelCity { get; set; }
        public string hotelAddress { get; set; }
        public DateTime bookingDate { get; set; }
        public DateTime checkInDate { get; set; }
        public DateTime checkOutDate { get; set; }
        public int Uid { get; set; }
    }
}
