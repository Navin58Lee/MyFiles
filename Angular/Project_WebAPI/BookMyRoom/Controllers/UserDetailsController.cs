using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer;
using Entities;
using System.Web.Http.Description;

namespace BookMyRoom.Controllers
{
    public class UserDetailsController : ApiController
    {
        UserDetailsManager userDetailsManager = new UserDetailsManager();

        // POST: api/UserDetails
        [HttpPost]
        [ResponseType(typeof(UserDetails))]
        public int PostUserDetail(UserDetails userDetails)
        {

            int result = userDetailsManager.SaveUserDetail(userDetails);
            return result;
        }

        [Route("api/UserDetails/Validate")]
        public bool Validation(UserDetails user)
        {
            bool res = userDetailsManager.CheckValidation(user);
            return res;
        }

        /// <summary>
        ///  //Method to retrive the details of Loggeduser by using "finduser" object
        /// </summary>
        /// <param name="finduser"></param>
        /// <returns></returns>
        [Route("api/UserDetails/LoggedUser")]
        public UserDetails LoggedUser(UserDetails finduser)
        {
            return userDetailsManager.LoggedUser(finduser);
        }
        /// <summary>
        /// Method to update the reward points based on purchase. 
        /// </summary>
        /// <param name="updaterewards"></param>
        /// <returns></returns>
        [Route("api/UserDetails/UpdateRewards")]
        public int UpdateRewards(UserDetails updaterewards)
        {
            return userDetailsManager.UpdateRewards(updaterewards);
        }
    }
}
