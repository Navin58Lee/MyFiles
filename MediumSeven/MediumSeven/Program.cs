using System;
using System.Text.RegularExpressions;
namespace MediumSeven
{
    class User
    {
        public static long userId;
        public static string createdDate;
        public static string dateOfBirth;
        public static string fullName;
        public static string gender;
        public static string loginId;
        public static string username;
        public static string password;
        public static void createUser()
        {
            Console.WriteLine("Enter the userId");
            userId = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Date of Creation");
            createdDate = Console.ReadLine();
            Console.WriteLine("Enter your Date of Birth");
            dateOfBirth = Console.ReadLine();
            Console.WriteLine("Enter your full name");
            fullName = Console.ReadLine();
            Console.WriteLine("Enter your gender");
            gender = Console.ReadLine();
            Console.WriteLine("Enter your Login ID");
            try
            {
                loginId = Console.ReadLine();
                if (loginId.Length < 5)
                {
                    throw new InvalidLoginIdException("Invalid");
                }
            }
            catch (InvalidLoginIdException)
            {
                Console.WriteLine("Login ID must have more than 5 characters");
            }
            Console.WriteLine("Enter the username");
            username = Console.ReadLine();
            Console.WriteLine("Enter the password");
            try
            {
                password = Console.ReadLine();
                Match m = Regex.Match(password, @"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9]).*");
                //Console.WriteLine(m.Success);
                if(m.Success==false)
                {
                    throw new InvalidPasswordException("Invalid");
                }
                //else
                //{
                  //  Console.WriteLine("Correct");
                //}

            }
            catch (InvalidPasswordException)
            {
              Console.Write("Password entered is not in the correct format" + '\n' + "Your password must have atleast a digit and also must be a combination of upper and lower cases" + '\n');
            }
        }
        public static void showUser()
        {
            Console.WriteLine("User ID : " + userId);
            Console.WriteLine("Created Date : " + createdDate);
            Console.WriteLine("Date of Birth : " + dateOfBirth);
            Console.WriteLine("Full Name : " + fullName);
            Console.WriteLine("Gender : " + gender);
            Console.WriteLine("Login ID : " + loginId);
            Console.WriteLine("Username : " + username);
            Console.WriteLine("Password : " + password);
        }
    }
    class InvalidLoginIdException : Exception
    {
        public InvalidLoginIdException(string s) : base(s)
        {

        }
    }
        class InvalidPasswordException : Exception
        {
            public InvalidPasswordException(string i) : base(i)
            {

            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            User.createUser();
            User.showUser();
            Console.ReadKey();
        }
    }
}
