using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLayer
{
    public class UserDetailsSave
    {
        private readonly DbContext.BookMyRoomDBContext dbContext = new DbContext.BookMyRoomDBContext();


        public int SaveUserDetails(UserDetails userDetails)
        {
            userDetails.RewardPoints = 5;
            try
            {

                dbContext.userDetails.Add(userDetails);
                this.dbContext.SaveChanges();
            }
            catch 
            {
                return 0;
            }
            return 1;
        }
       

        public bool CheckValidation(UserDetails user)
        {
            var q = from UserDetails in dbContext.userDetails
                    where UserDetails.UserName == (user.UserName)
                    && UserDetails.Password == (user.Password)
                    select UserDetails;
            if (q.Any())
            {

                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Retriving the row of LoggedUSer details into UserDetails object <<user>> from parameter "user" 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public UserDetails LoggedUser(UserDetails user)
        {  
            

            UserDetails users = dbContext.userDetails.SingleOrDefault(x =>
               x.UserName == user.UserName && x.Password==user.Password);
            return users;
        }
        /// <summary>
        /// Saving the changes to database by using UserDetails Object -- "user"
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public int UpdateRewards(UserDetails user)
        {
            //Trying to change the rewards point of the logged user
            try
            {
                dbContext.Entry(user).State = EntityState.Modified;
                dbContext.SaveChanges();
                //After perfect changes this method returns 1
                return 1;
            }
            catch
            {
                //if any error occurs catch block returns 0
                return 0;
            }

        }
    }
}
