using BookMyRoom.DataAccessLayer.DbContext;
using BookMyRoom.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BookMyRoom.DataAccessLayer
{
    public class RoomDetailsSearch
    {
        private readonly RoomDetailsDBContext db = new RoomDetailsDBContext();
        public List<SearchHotel> GetRoomDetails(SearchHotel hotel)
        {

            var filterBookedHotels = (from HD in db.hotelDetails
                                      join HCM in db.hotelCityMapping on HD.hotelId equals HCM.hotelId
                                      join CD in db.cityDetails on HCM.cityId equals CD.cityId
                                      join RD in db.roomDetails on HD.hotelId equals RD.hotelId
                                      join RBD in db.roomBookingDetails on RD.Room_Id equals RBD.roomId
                                      join B in db.booking on RBD.Booking_Id equals B.bookingId
                                      where CD.City_Name == hotel.cityName
                                      && RD.Room_Type == hotel.roomType
                                      && ((B.CheckIn_Date > checkin && B.CheckIn_Date > checkout) || (B.Checkout_Date < checkin && B.Checkout_Date < checkout))
                                      select new
                                      {
                                          hotelName = HD.Hot_Name,
                                          hotelAdd = HD.Hot_Add,
                                          cityName = CD.City_Name,
                                          roomType = RD.Room_Type,
                                          roomId = RD.Room_Id
                                      })
                                      .ToList();
            var allHotels = (from HD in db.hotelDetails
                             join HCM in db.hotelCityMapping on HD.hotelId equals HCM.hotelId
                             join CD in db.cityDetails on HCM.cityId equals CD.cityId
                             join RD in db.roomDetails on HD.hotelId equals RD.hotelId
                             join RBD in db.roomBookingDetails on 1 equals 1
                             join B in db.booking on 1 equals 1
                             where RD.roomId != RBD.roomId &&
                             RBD.bookingId != B.bookingId &&
                             CD.cityName == hotel.cityName
                             && RD.roomType == hotel.roomType
                             select new
                             {
                                 hotelName = HD.Hot_Name,
                                 hotelAdd = HD.Hot_Add,
                                 cityName = CD.City_Name,
                                 roomType = RD.Room_Type,
                                 roomId = RD.Room_Id
                             }).Distinct().ToList();

            var allAvailableBookedHotels = (from HD in db.hotelDetails
                                            join HCM in db.hotelCityMapping on HD.hotelId equals HCM.hotelId
                                            join CD in db.cityDetails on HCM.cityId equals CD.cityId
                                            join RD in db.roomDetails on HD.hotelId equals RD.hotelId
                                            join RBD in db.roomBookingDetails on RD.Room_Id equals RBD.roomId
                                            join B in db.booking on RBD.Booking_Id equals B.bookingId
                                            where CD.cityName == hotel.cityName
                                            && RD.roomType == hotel.roomType
                                            select new
                                            {
                                                hotelName = HD.Hot_Name,
                                                hotelAdd = HD.Hot_Add,
                                                cityName = CD.City_Name,
                                                roomType = RD.Room_Type,
                                                roomId = RD.Room_Id
                                            }).Distinct().ToList();
            allHotels.RemoveAll(x => allAvailableBookedHotels.Any(y => y.roomId == x.roomId));
            var result = allHotels.Concat(filterBookedHotels).ToList<SearchHotel>();
            return result;
        }
.
        }


    }

