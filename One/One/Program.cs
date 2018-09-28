using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace One
{

class ClsPerson
    {
        public string name;
        public ClsPerson(string nam)
        {
            Name = nam;
        }

        public string Name { get => name; set => name = value; }
    }
    class TestMain
    {
        static void Main(string[] args)
        {
            ClsPerson a = new ClsPerson("Ross");
            ClsPerson b = new ClsPerson("Rachel");
            ClsPerson c = new ClsPerson("Phoebe");
            ClsPerson d = new ClsPerson("Joey");
            ClsPerson e = new ClsPerson("Chandler");
            ClsPerson f = new ClsPerson("Monica");
            ArrayList arr = new ArrayList();
            arr.Add(a.Name);
            arr.Add(b.Name);
            arr.Add(c.Name);
            arr.Add(d.Name);
            arr.Add(e.Name);
            arr.Add(f.Name);
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
