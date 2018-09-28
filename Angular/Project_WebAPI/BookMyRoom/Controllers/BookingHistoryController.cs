using BusinessLayer;
using Entities;
using System;   
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookMyRoom.Controllers
{
    public class BookingHistoryController : ApiController
    {
        private readonly BookingHistoryManager bookingObj = new BookingHistoryManager();
        [HttpPut]
        public List<History> BookingHistory(History Loggeduser)
        {
            Loggeduser.Uid = 2;
            return bookingObj.GetDetails(Loggeduser);
        }
    }
}
