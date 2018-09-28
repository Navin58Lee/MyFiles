using BookMyRoom.BusinessLayer;
using BookMyRoom.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
namespace BookMyRoomNew.Controllers
{
    public class BookMyRoomController : ApiController
    {
        private readonly BookMyRoomManager hotelObj = new BookMyRoomManager();
        [HttpPut]
        public IHttpActionResult SearchHotels(SearchHotel hotel)
        {
            return Ok(hotelObj.GetDetails(hotel));
        }
    }
}
