using System;
using System.Collections;
using System.Collections.Generic;
namespace Collections2Seven
{
    class ClsStudent
    {
        public string name;
        public int id;
        public ClsStudent()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           ClsStudent s1 = new ClsStudent();
            s1.id = 1;
            ClsStudent s2 = new ClsStudent();
            s2.id = 3;
            ClsStudent s3 = new ClsStudent();
            s3.id = 6;
            ClsStudent s4 = new ClsStudent();
            s4.id = 8;
            ClsStudent s5 = new ClsStudent();
            s5.id = 7;
            Dictionary<string, ClsStudent> d = new Dictionary<string, ClsStudent>();
            try
            {
                d.Add("John", s1);
                d.Add("Bill", s2);
                d.Add("Meeta", s3);
                d.Add("Jolly", s4);
                d.Add("Bill", s5);
            }
            catch (Exception y)
            {
                Console.WriteLine(y.Message);
            }
            Console.WriteLine(d["Meeta"].id);
            Console.ReadKey();
        }
    }
}
