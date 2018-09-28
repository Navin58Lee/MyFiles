using DatabaseAccessLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BookingHistoryManager
    {
        private readonly BookingHistory obj = new BookingHistory();
        public List<History> GetDetails(History Loggeduser)
        {
            return obj.Booking(Loggeduser);
        }
    }
}
