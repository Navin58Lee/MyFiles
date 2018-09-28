using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DatabaseAccessLayer;
using System.Security.Cryptography;

namespace BusinessLayer
{
    public class UserDetailsManager
    {

        private readonly UserDetailsSave saveUserDetails = new UserDetailsSave();
        public int SaveUserDetail(UserDetails userDetails)
        {
            userDetails.Password = ComputeSha256Hash(userDetails.Password);
            userDetails.UserName = ComputeSha256Hash(userDetails.UserName);
            int result = saveUserDetails.SaveUserDetails(userDetails);
            return result;
        }
        public bool CheckValidation(UserDetails user)
        {
            user.Password = ComputeSha256Hash(user.Password);
            user.UserName = ComputeSha256Hash(user.UserName);
            bool res;
            res = saveUserDetails.CheckValidation(user);
            return res;
        }

        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public UserDetails LoggedUser(UserDetails user)
        {
            user.Password = ComputeSha256Hash(user.Password);
            user.UserName = ComputeSha256Hash(user.UserName);

            return saveUserDetails.LoggedUser(user);
        }
        public int UpdateRewards(UserDetails user)
        {
            return saveUserDetails.UpdateRewards(user);
        }
    }
}
