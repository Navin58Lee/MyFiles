using DatabaseAccessLayer.DbContext;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLayer
{
    public class BookingHistory
    { 
            private readonly BookMyRoomDBContext db = new BookMyRoomDBContext();
            public List<History> Booking(History Loggeduser)
            {
                var bookingHistory = (from RBD in db.roomBookingDetails
                                      join UD in db.userDetails on RBD.Uid equals UD.Uid
                                      join B in db.booking on RBD.bookingId equals B.bookingId
                                      join RD in db.roomHotel on RBD.roomId equals RD.roomId
                                      join HD in db.hotelDetails on RD.hotelId equals HD.hotelId
                                      where Loggeduser.Uid == UD.Uid
                                      select new History
                                      {
                                          hotelId = HD.hotelId,
                                          hotelName = HD.hotelName,
                                          hotelCity = "",
                                          hotelAddress = HD.hotelAddress,
                                          bookingDate = B.bookingDate,
                                          checkInDate = B.checkInDate,
                                          checkOutDate = B.checkOutDate

                                      }).ToList();
                return bookingHistory;                     
            }   
    }
}
