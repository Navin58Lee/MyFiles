using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aysnc
{
    class Program
    {
        public static int c = 0;
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine(DateTime.Now.ToLongTimeString());
                Console.WriteLine("Enter a number");
                int n = int.Parse(Console.ReadLine());
                Compute();
                Console.WriteLine(DateTime.Now.ToLongTimeString());
                Console.WriteLine("You Entered : "+n);
            }
        }
        static async void Compute()
        {
            int s = await Task.Run(() => Function());
            Console.WriteLine("Count = " + c);
        }
        //static void Compute()
        //{
        //    int s = Function();
        //    Console.WriteLine("Count = "+c);
        //}
        static int Function()
        {
            c = 0;
            for(int i=0;i<100000;i++)
            {
                for(int j=0;j<20000;j++)
                {
                    c++;
                }
            }
            return c;
        }
    }
}
