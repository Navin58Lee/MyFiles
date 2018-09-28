using System;

namespace MediumTwo
{
    class User
    {
        public long userId;
        public string createdDate;
        public string dateOfBirth;
        public string fullName;
        public string gender;
        public string loginId;
        public string username;
        public string password;
        public User(long uid, string cd, string dob, string fname, string gndr, string lid, string uname, string pwd)
        {
            userId = uid;
            createdDate = cd;
            dateOfBirth = dob;
            fullName = fname;
            gender = gndr;
            loginId = lid;
            username = uname;
            password = pwd;

        }
        public static void showUserDetails(User u)
        {
            Console.WriteLine("User ID : " + u.userId);
            Console.WriteLine("Created Date : " + u.createdDate);
            Console.WriteLine("Date of Birth : " + u.dateOfBirth);
            Console.WriteLine("Full Name : " + u.fullName);
            Console.WriteLine("Gender : " + u.gender);
            Console.WriteLine("Login Id : " + u.loginId);
            Console.WriteLine("Username : " + u.username);
            Console.WriteLine("Password : " + u.password);
        }
    }
    class UserMgr
    {
        public static User createUser()
        {
            User u = new User(45, "01/01/2018", "30/03/1997", "Michael Scofield", "M", "nonone@hotmail.com", "whatever", "********");
            return u;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User u = UserMgr.createUser();
            User.showUserDetails(u);
            Console.ReadKey();
        }
    }
}
