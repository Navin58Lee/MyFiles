using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using Database;
namespace Business
{
    public class BusinessClass
    {
        public void CallDataInsert(int id,string name,int age)
        {
            DatabaseClass dc = new DatabaseClass();
            dc.DataInsert(id, name, age);
        }
        public DataSet CallDataRetrieve()
        {
            DatabaseClass dc = new DatabaseClass();
            DataSet set = dc.DataRetrieve();
            return set;
        }
    }
}
