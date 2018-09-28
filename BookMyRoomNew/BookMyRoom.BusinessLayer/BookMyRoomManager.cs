using BookMyRoom.DataAccessLayer;
using BookMyRoom.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BookMyRoom.BusinessLayer
{
    public class BookMyRoomManager
    {
        private readonly RoomDetailsSearch hotelObj = new RoomDetailsSearch();
        public List<SearchHotel> GetDetails(SearchHotel hotel)
        {

            var checkin = Convert.ToDateTime(hotel.checkinDate);
            var checkout = Convert.ToDateTime(hotel.checkoutDate);
            List<SearchHotel> roomDetails = new List<SearchHotel>();

            DateTime today = DateTime.Now;
            DateTime maxDays = today.AddDays(14);
            DateTime maxCheckIn = today.AddDays(90); 
            if(checkin>=today && (checkout>today && checkout<maxDays) && (checkin<maxCheckIn))
            {
                roomDetails = GetRoomDetails(hotel);
            }
            return roomDetails;
        }
    }
}
