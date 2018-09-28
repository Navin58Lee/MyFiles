using System;
using System.Collections.Generic;
namespace Collections2Six
{
    class ClsStudent
    {
        public string name;
        public int age;
        public ClsStudent()
        {
           
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClsStudent s1 = new ClsStudent();
            s1.name="Micahel";
            s1.age = 24;
            ClsStudent s2 = new ClsStudent();
            s2.name = "Sarah";
            s2.age = 33;
            ClsStudent s3 = new ClsStudent();
            s3.name = "Dominic";
            s3.age = 26;
            ClsStudent s4 = new ClsStudent();
            s4.name = "Stefie";
            s4.age = 25;
            List<ClsStudent> n = new List<ClsStudent>();
            n.Add(s1);
            n.Add(s2);
            n.Add(s3);
            n.Add(s4);
            try
            {
                foreach (ClsStudent i in n)
                {
                    Console.WriteLine(i.name + " "+i.age);
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Exception Occured");
            }
            Console.ReadKey();
        }
    }
}
