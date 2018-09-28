using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation;
using StudentEntity;


namespace Business
{
    public class BusinessClass
    {
        public void InsertData(StudentClass s1, StudentClass s2,StudentClass s3)
        {
            Dictionary<int, StudentClass> d = new Dictionary<int, StudentClass>();
            d.Add(99, s1);
            d.Add(88, s2);
            d.Add(44, s3);
            DatabaseClass db = new DatabaseClass();
            db.DataInsert(d);
        }
    }
}
