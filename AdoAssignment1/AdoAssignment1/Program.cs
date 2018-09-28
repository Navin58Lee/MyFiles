using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AdoAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string con = "Data Source = G1C2ML18279; Initial Catalog = Assignment; Integrated Security = True";
            SqlConnection c = new SqlConnection(con);

            c.Open();
            string q = "Insert into Table_1 values(@id,@studentname,@age,@classteacherid)";
            SqlCommand s = new SqlCommand(q, c);
            //insert
            s.Parameters.AddWithValue("@id", 1);
            s.Parameters.AddWithValue("@studentname", "Mike");
            s.Parameters.AddWithValue("@age", 34);
            s.Parameters.AddWithValue("@classteacherid", 45);
            s.ExecuteNonQuery();
            //retrieve
            q = "Select * from Table_1";
            s = new SqlCommand(q, c);
            SqlDataReader d = s.ExecuteReader();
            while (d.Read())
            {
                Console.WriteLine(d[0].ToString() + " " + d[1].ToString() + " " + d[2].ToString()+" "+d[3].ToString());
            }
            Console.ReadKey();
        }
    }
}
