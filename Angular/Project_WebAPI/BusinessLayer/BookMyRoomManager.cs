using DatabaseAccessLayer;
using Entities;
using Entities.MVC.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BookMyRoomManager
    {
        private readonly RoomDetailsSearch hotelObj = new RoomDetailsSearch();
        public List<Output> GetDetails(SearchCriteria hotel)
        {
            var checkin = Convert.ToDateTime(hotel.hotelFromDate);
            var checkout = Convert.ToDateTime(hotel.hotelToDate);
            var difference = (checkout - checkin).TotalDays;

            List<Output> roomDetails = new List<Output>();


            DateTime today = DateTime.Today;
            DateTime maxDays = checkin.AddDays(14);
            DateTime maxCheckIn = today.AddDays(90);

            if (checkin >= today && (checkout > checkin && checkout < maxDays) && (checkin < maxCheckIn))
            {

                roomDetails = hotelObj.GetRoomDetails(hotel);
            }

            return roomDetails;
        }
        public int Storedata(BookingTransfer obj)
        {

            return hotelObj.Storedata(obj);
        }
    }
}
