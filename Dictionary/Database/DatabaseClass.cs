using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class DatabaseClass
    {
        public void DataInsert(int id, string name, int age)
        {
            string conn = "Data Source=G1C2ML18279;Initial Catalog=Sunday;Integrated Security=True";
            SqlConnection c = new SqlConnection(conn);
            c.Open();
            string q = "Insert into Table_1 values(@id,@name,@age)";
            SqlCommand s = new SqlCommand(q, c);
            s.Parameters.AddWithValue("@id", id);
            s.Parameters.AddWithValue("@name", name);
            s.Parameters.AddWithValue("@age", age);
            s.ExecuteNonQuery();
            c.Close();
        }
    }
}
