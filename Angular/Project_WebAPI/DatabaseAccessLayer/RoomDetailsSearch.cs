using DatabaseAccessLayer.DbContext;
using Entities;
using Entities.MVC.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLayer
{
    public class RoomDetailsSearch
    {
        private readonly BookMyRoomDBContext db = new BookMyRoomDBContext();
        public List<Output> GetRoomDetails(SearchCriteria hotel)
        {
            var availableBookedHotels = (from booking in db.booking
                                         join roomBookingDetails in db.roomBookingDetails on booking.bookingId equals roomBookingDetails.bookingId
                                         join roomDetails in db.roomHotel on roomBookingDetails.roomId equals roomDetails.roomId
                                         join hotelDetails in db.hotelDetails on roomDetails.hotelId equals hotelDetails.hotelId
                                         join hotelCityMap in db.hotelCityMap on hotelDetails.hotelId equals hotelCityMap.hotelId
                                         join cityDetails in db.cityDetails on hotelCityMap.cityId equals cityDetails.cityId
                                         where (cityDetails.cityName == hotel.hotelCity && roomDetails.roomType == hotel.hotelRoomType && ((booking.checkInDate >= hotel.hotelFromDate && booking.checkInDate >= hotel.hotelToDate) || (booking.checkOutDate <= hotel.hotelFromDate && booking.checkOutDate <= hotel.hotelFromDate)))
                                         select new Output
                                         {
                                             hotelId = roomDetails.roomId,
                                            hotelName = hotelDetails.hotelName,
                                            hotelRoomType = roomDetails.roomType,
                                            hotelFromDate = hotel.hotelFromDate,
                                            hotelToDate = hotel.hotelToDate,
                                            hotelPrice = roomDetails.price,
                                            hotelCity = cityDetails.cityName,
                                            hotelRating = roomDetails.starRating,
                                            hotelUrl = roomDetails.imageUrl

                                         }).ToList();
                
            
            var totalBookedHotels = (from booking in db.booking
                                 join roomBookingDetails in db.roomBookingDetails on booking.bookingId equals roomBookingDetails.bookingId
                                 join roomDetails in db.roomHotel on roomBookingDetails.roomId equals roomDetails.roomId
                                 join hotelDetails in db.hotelDetails on roomDetails.hotelId equals hotelDetails.hotelId
                                 join hotelCityMap in db.hotelCityMap on hotelDetails.hotelId equals hotelCityMap.hotelId
                                 join cityDetails in db.cityDetails on hotelCityMap.cityId equals cityDetails.cityId
                                 where (roomDetails.roomType == hotel.hotelRoomType && cityDetails.cityName == hotel.hotelCity)
                                 select new Output
                                 {
                                     hotelId = roomDetails.roomId,
                                     hotelName = hotelDetails.hotelName,
                                     hotelRoomType = roomDetails.roomType,
                                     hotelFromDate = hotel.hotelFromDate,
                                     hotelToDate = hotel.hotelToDate,
                                     hotelPrice = roomDetails.price,
                                     hotelCity = cityDetails.cityName,
                                     hotelRating = roomDetails.starRating,
                                     hotelUrl = roomDetails.imageUrl

                                 }).Distinct().ToList();
            
           var  totalHotels = (from hotelDetails in db.hotelDetails
                                        join hotelCityMap in db.hotelCityMap on hotelDetails.hotelId equals hotelCityMap.hotelId
                                        join cityDetails in db.cityDetails on hotelCityMap.cityId equals cityDetails.cityId
                                        join roomDetails in db.roomHotel on hotelDetails.hotelId equals roomDetails.hotelId
                                        where                                     
                                        cityDetails.cityName == hotel.hotelCity
                                        && roomDetails.roomType == hotel.hotelRoomType
                                        select new Output
                                        {
                                            hotelId = roomDetails.roomId,
                                            hotelName = hotelDetails.hotelName,
                                            hotelRoomType = roomDetails.roomType,
                                            hotelFromDate = hotel.hotelFromDate,
                                            hotelToDate = hotel.hotelToDate,
                                            hotelPrice = roomDetails.price,
                                            hotelCity = cityDetails.cityName,
                                            hotelRating = roomDetails.starRating,
                                            hotelUrl = roomDetails.imageUrl

                                        }).Distinct().ToList();
            totalHotels.RemoveAll(x => totalBookedHotels.Any(y => y.hotelId == x.hotelId));

            var result = totalHotels.Concat(availableBookedHotels).ToList<Output>();

            return result;
        }
        public int Storedata(BookingTransfer obj)
        {
            Booking book = new Booking();
            book.bookingAmount = obj.bookingAmount;
            book.checkInDate = obj.checkInDate;
            book.checkOutDate = obj.checkOutDate;
            book.discountAmount = obj.discountAmount;
            book.bookingDate = DateTime.Now;
            obj.bookingDate = book.bookingDate;
            try
            {
                
                
                db.booking.Add(book);
                db.SaveChanges();

  //              RoomIdBookingIdUpdate(obj);
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public void RoomIdBookingIdUpdate (BookingTransfer obj)
        {
            int bookingIdToMap =(from booking in db.booking
                                 where booking.bookingDate == obj.bookingDate && booking.checkInDate == obj.checkInDate
                                 && booking.checkOutDate == obj.checkOutDate && booking.bookingAmount == obj.bookingAmount
                                 && booking.discountAmount == obj.discountAmount
                                 select booking.bookingId).FirstOrDefault();

            RoomBookingDetails roomBookingUpdate = new RoomBookingDetails();
            try
            {
                // roomBookingUpdate.bookingId = Convert.ToInt32(bookingIdToMap);
                roomBookingUpdate.bookingId = bookingIdToMap;
                roomBookingUpdate.roomId = obj.roomId;

                db.roomBookingDetails.Add(roomBookingUpdate);
                db.SaveChanges();
            }
            catch
            {
                Console.WriteLine("Alert");
            }
        }
    }
}
