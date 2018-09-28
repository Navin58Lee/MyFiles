using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;
using Student;

namespace Business
{
    public class BusinessClass
    {
        public void InsertData(StudentClass s1,StudentClass s2)
        {
            Dictionary<int, StudentClass> d = new Dictionary<int, StudentClass>();
            d.Add(1, s1);
            d.Add(2, s2);
        }
    }
}
