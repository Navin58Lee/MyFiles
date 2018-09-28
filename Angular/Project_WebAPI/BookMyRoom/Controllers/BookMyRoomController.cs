using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Entities.MVC.Models;
using BusinessLayer;
using Entities;

namespace BookMyRoom.Controllers
{
    public class BookMyRoomController : ApiController
    {
        private readonly BookMyRoomManager hotelObj = new BookMyRoomManager();
        [HttpPut]
        public IHttpActionResult SearchHotels(SearchCriteria hotel)
        {
           return Ok(hotelObj.GetDetails(hotel));
        }
        [HttpPost]
        public int Storedata(BookingTransfer obj)
        {

            return hotelObj.Storedata(obj);
        }
    }
}
