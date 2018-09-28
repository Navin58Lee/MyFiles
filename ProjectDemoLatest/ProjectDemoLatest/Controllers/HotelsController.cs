using ProjectDemoLatest.Models;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
namespace ProjectDemoLatest.Controllers
{

    public class HotelsController : ApiController
    {
        private HotelContext db = new HotelContext();

        // GET: api/Hotels
        public IQueryable<Dummy> GetHotels()
        {
            return db.Dummy;
        }
        [HttpPut]
        public IHttpActionResult SearchHotel(Dummy hotel)
        {
            //var result = db.Hotel_City_Mapping
            //    .Join(db.Hotel_Details, c => c.Hotel_Details.Hot_Id, cm => cm.Hot_Id, (c, cm) => new { Hot_Name = c, City_Details=c})
            //    .Join(db.City_Details, c => c.City_Details.City_Id, y => y.City_Id, (c, y) => new { City_Name = y })
            //    .Select(a => a.City_Name)
            //    .Where(b => b.City_Name == hotel.City_Name)
            //    .ToList();
            //return Ok(result);




            //var result = (from HD in db.Hotel_Details
            //              join HCM in db.Hotel_City_Mapping on HD.Hot_Id equals HCM.Hot_Id
            //              join CD in db.City_Details on HCM.City_Id equals CD.City_Id
            //              join RD in db.Room on HD.Hot_Id equals RD.Hot_Id
            //              where CD.City_Name == hotel.City_Name && RD.Room_Type==hotel.Room_Type
            //              select new { Hot_Name = HD.Hot_Name, Hot_Add = HD.Hot_Add, City_Name = CD.City_Name, Room_Type = RD.Room_Type })
            //              .ToList();
            //    return Ok(result);


            var cin = Convert.ToDateTime(hotel.CheckIn_Date);

            var checkinYear = cin.Year;
            var checkinMonth = cin.Month;
            var checkinDate = cin.Day;


            var cout = Convert.ToDateTime(hotel.CheckOut_Date);

            var checkoutYear = cout.Year;
            var checkoutMonth = cout.Month;
            var checkoutDate = cout.Day;

            bool ex = (checkinYear <= checkoutYear) && ((checkinMonth <= checkoutMonth) && (checkinDate <= checkoutDate) || (checkinMonth < checkoutMonth));

            if (ex)
            {
                var filterBookedHotels = (from HD in db.Hotel_Details
                                          join HCM in db.Hotel_City_Mapping on HD.Hot_Id equals HCM.Hot_Id
                                          join CD in db.City_Details on HCM.City_Id equals CD.City_Id
                                          join RD in db.Room on HD.Hot_Id equals RD.Hot_Id
                                          join RBD in db.Room_Booking_Details on RD.Room_Id equals RBD.Room_Id
                                          join B in db.Booking on RBD.Booking_Id equals B.Booking_Id
                                          where CD.City_Name == hotel.City_Name
                                          && RD.Room_Type == hotel.Room_Type
                                          && ((B.CheckIn_Date > cin && B.CheckIn_Date > cout) || (B.Checkout_Date < cin && B.Checkout_Date < cout))
                                          select new
                                          {
                                              Hot_Name = HD.Hot_Name,
                                              Hot_Add = HD.Hot_Add,
                                              City_Name = CD.City_Name,
                                              Room_Type = RD.Room_Type,
                                              Room_Id = RD.Room_Id
                                          })
                                          .ToList();
                var allHotels = (from HD in db.Hotel_Details
                                 join HCM in db.Hotel_City_Mapping on HD.Hot_Id equals HCM.Hot_Id
                                 join CD in db.City_Details on HCM.City_Id equals CD.City_Id
                                 join RD in db.Room on HD.Hot_Id equals RD.Hot_Id
                                 join RBD in db.Room_Booking_Details on 1 equals 1
                                 join B in db.Booking on 1 equals 1
                                 where RD.Room_Id != RBD.Room_Id &&
                                 RBD.Booking_Id != B.Booking_Id &&
                                 CD.City_Name == hotel.City_Name
                                 && RD.Room_Type == hotel.Room_Type
                                 select new
                                 {
                                     Hot_Name = HD.Hot_Name,
                                     Hot_Add = HD.Hot_Add,
                                     City_Name = CD.City_Name,
                                     Room_Type = RD.Room_Type,
                                     Room_Id = RD.Room_Id
                                 }).Distinct().ToList();

                var allAvailableBookedHotels = (from HD in db.Hotel_Details
                                                join HCM in db.Hotel_City_Mapping on HD.Hot_Id equals HCM.Hot_Id
                                                join CD in db.City_Details on HCM.City_Id equals CD.City_Id
                                                join RD in db.Room on HD.Hot_Id equals RD.Hot_Id
                                                join RBD in db.Room_Booking_Details on RD.Room_Id equals RBD.Room_Id
                                                join B in db.Booking on RBD.Booking_Id equals B.Booking_Id
                                                where CD.City_Name == hotel.City_Name
                                                && RD.Room_Type == hotel.Room_Type
                                                select new
                                                {
                                                    Hot_Name = HD.Hot_Name,
                                                    Hot_Add = HD.Hot_Add,
                                                    City_Name = CD.City_Name,
                                                    Room_Type = RD.Room_Type,
                                                    Room_Id = RD.Room_Id
                                                }).Distinct().ToList();


                //var availableHotels = (from a in allHotels
                //                       join b in allAvailableBookedHotels on a.Room_Type equals b.Room_Type
                //                       where (a.Room_Id != b.Room_Id)
                //                       select new
                //                       {
                //                           Hot_Name = a.Hot_Name,
                //                           Hot_Add = a.Hot_Add,
                //                           City_Name = a.City_Name,
                //                           Room_Type = a.Room_Type,
                //                           Room_Id = a.Room_Id
                //                       }).Distinct().ToList();

                var result = allHotels.Except(allAvailableBookedHotels).ToList();

                var final = result.Concat(filterBookedHotels).ToList();

                return Ok(final);
            }
            else
            {
                return Ok();
            }
            //var final = result3.Concat(result).ToList();
            //if (result == null)
            //{
            //    return Ok(result1);
            //}
            //else
            //{
            //    var check = result1.Except(result).ToList();
            //    return Ok(check);
            //}
            //return Ok(result2);
        }
    }
}
