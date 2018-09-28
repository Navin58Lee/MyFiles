using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Database;

namespace Business
{
    public class BusinessClass
    {
        public void CallInsert(string id,string name,string age)
        {
            Class1 c = new Class1();
            c.InsertData(id,name,age);
        }
    }
}
