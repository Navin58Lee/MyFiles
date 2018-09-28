using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ProjectDemo.Models;
namespace ProjectDemo.Controllers
{
    public class HotelsController : ApiController
    {
        private HotelContext db = new HotelContext();

        // GET: api/Hotels
        public IQueryable<Hotel> GetHotels()
        {
            return db.Hotels;
        }

        // GET: api/Hotels/5
        [ResponseType(typeof(Hotel))]
        public IHttpActionResult GetHotel(int id)
        {
            Hotel hotel = db.Hotels.Find(id);
            if (hotel == null)
            {
                return NotFound();
            }

            return Ok(hotel);
        }

        // PUT: api/Hotels/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHotel(int id, Hotel hotel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hotel.Hotel_Id)
            {
                return BadRequest();
            }

            db.Entry(hotel).State = EntityState.Modified;
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Hotels
        [ResponseType(typeof(Hotel))]
        public IHttpActionResult PostHotel(Hotel hotel)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            db.Hotels.Add(hotel);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = hotel.Hotel_Id }, hotel);
        }

        // DELETE: api/Hotels/5
        [ResponseType(typeof(Hotel))]
        public IHttpActionResult DeleteHotel(int id)
        {
            Hotel hotel = db.Hotels.Find(id);
            if (hotel == null)
            {
                return NotFound();
            }

            db.Hotels.Remove(hotel);
            db.SaveChanges();

            return Ok(hotel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        private bool HotelExists(int id)
        {
            return db.Hotels.Count(e => e.Hotel_Id == id) > 0;
        }
        [HttpPut]
        public IHttpActionResult SearchEmployee(Hotel hotel)
        {
            var checkin = Convert.ToDateTime(hotel.Check_In);
            var checkinYear = checkin.Year;
            var checkinMonth = checkin.Month;
            var checkinDate = checkin.Day;
                
                

            var checkout = Convert.ToDateTime(hotel.Check_Out);
            var checkoutYear = checkout.Year;
            var checkoutMonth = checkout.Month;
            var checkoutDate = checkout.Day;
            bool ex = (checkinYear <= checkoutYear) && ((checkinMonth <= checkoutMonth) && (checkinDate <= checkoutDate) || (checkinMonth < checkoutMonth));
            if (ex)
            {
                //var result = db.Hotels
                //            .Where(x => x.City.Contains(hotel.City))
                //            .Where(x => x.Room_Type.Contains(hotel.Room_Type))
                //            .Where(x => x.Check_In <= checkin && x.Check_Out >= checkout).ToList<Hotel>();
                //var result = db.Hotels
                //         .Where(x => x.City.Contains(hotel.City))
                //         .Where(x => x.Room_Type.Contains(hotel.Room_Type))
                //         .Where(x => !x.Check_In.Contains(hotel.Check_In) && )
                //         .Where(x => !x.Check_Out.Contains(hotel.Check_Out))
                //         .ToList<Hotel>();
                var result = db.Hotels.Where(x => (x.Check_In.Year >= checkinYear && x.Check_In.Year >= checkoutYear)
                                                 && (x.Check_In.Month >= checkinMonth && x.Check_In.Month >= checkoutMonth)
                                                 && (((x.Check_In.Day >= checkinDate) || (x.Check_In.Month > checkinMonth)) &&
                                                 ((x.Check_In.Day >= checkoutDate) || x.Check_In.Month > checkoutMonth))
                                                 || (x.Check_Out.Year <= checkinYear && x.Check_Out.Year <= checkoutYear)
                                                 && (x.Check_Out.Month <= checkinMonth && x.Check_Out.Month <= checkoutMonth)
                                                 && ((x.Check_Out.Day <= checkoutDate) || (x.Check_Out.Month < checkoutMonth))).DefaultIfEmpty()
                                                 .Where(x => (x.City.Contains(hotel.City)))
                                                 .Where(x => (x.Room_Type.Contains(hotel.Room_Type)))
                                                 .ToList<Hotel>();

                if (result != null)
                {
                    return Ok(result);
                }   
                else
                {
                    var k = "Not available";
                    return Ok(k.ToString());
                }
            }
            else
            {
                var k = "Not available";
                return Ok(k.ToString());
            }
        }
    }
}   
