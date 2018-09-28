using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentEntity;


namespace Presentation
{
    public class DatabaseClass
    {
        public void DataInsert(Dictionary<int, StudentClass> d)
        {
            string conn = "Data Source=G1C2ML18279;Initial Catalog=Dictionary;Integrated Security=True";
            SqlConnection c = new SqlConnection(conn);
            c.Open();
            foreach (var ab in d.Values)
            {
                string q = "Insert into Dictionary values(@id,@name,@age)";
                SqlCommand s = new SqlCommand(q, c);
                s.Parameters.AddWithValue("@id", ab.id);
                s.Parameters.AddWithValue("@name", ab.name);
                s.Parameters.AddWithValue("@age", ab.age);
                s.ExecuteNonQuery();
            }
            c.Close();
        }
    }
}
