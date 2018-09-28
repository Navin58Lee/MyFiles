using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscussionNew
{
    class Table_1
    {
        public int id;
        public string name;
        public int GetId()
        {
            return id;
        }
        public void SetId(int i)
        {
            id = i;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string nam)
        {
            name = nam;
        }   
    }
    class Program
    {
        static void Main(string[] args)
        {
            Table_1 t1 = new Table_1;
            t1.id = 58;
            t1.name = "Lee";
            

        }
    }
}
