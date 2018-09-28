using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentEntity;
using Business;

namespace DictionaryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentClass s1 = new StudentClass();
            s1.id = 101;
            s1.name = "Lee";
            s1.age = 24;
            StudentClass s2 = new StudentClass();
            s2.id = 100;
            s2.name = "Stephanie";
            s2.age = 23;
            StudentClass s3 = new StudentClass();
            s3.id = 55;
            s3.name = "Mike";
            s3.age = 21;
            BusinessClass b = new BusinessClass();
            b.InsertData(s1, s2,s3);
            Console.ReadLine();
        }
    }
}
