using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Data;


namespace Database
{
    public class DatabaseClass
    {
        public object GridView1 { get; private set; }

        public void DataInsert(int id, string name, int age)
        {
            string conn = "Data Source=G1C2ML18279;Initial Catalog=ThreeTier;Integrated Security=True";
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
        public DataSet DataRetrieve()
        {
            string conn = "Data Source=G1C2ML18279;Initial Catalog=ThreeTier;Integrated Security=True";
            SqlConnection c = new SqlConnection(conn);
            c.Open();
            string q = "Select *from Table_1";
            SqlCommand q1 = new SqlCommand(q, c);
            SqlDataAdapter dataAdapt = new SqlDataAdapter(q, conn);
            DataSet d = new DataSet();
            dataAdapt.Fill(d);
            return d;
        }
        
    }
}
