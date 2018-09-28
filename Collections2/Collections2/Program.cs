using System;
using System.Collections;
namespace Collections2
{
    public class Person
    {
        public string Name;
        public Person()
        {
            Name = "";
        }
    }
    class TestMain
    {
        public static void Main()
        {
            Person obj1 = new Person();
            obj1.Name = "John";

            Person obj2 = new Person();
            obj2.Name = "Bill";

            Person obj3 = new Person();
            obj3.Name = "Dell";

            Person obj4 = new Person();
            obj4.Name = "Misha";

            ArrayList list = new ArrayList();
            list.Add(obj1);
            list.Add(obj2);
            list.Add(obj3);
            list.Add(obj4);
            list.Add("123");
            try
            {
                foreach (Person p in list)
                {
                    Console.WriteLine(p.Name);
                }
            }
            catch (InvalidCastException )
            {
                Console.WriteLine("Exception Occured");
            }
            Console.ReadKey();
        }
    }

}
