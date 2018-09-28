using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            string con = "Data Source = G1C2ML18279; Initial Catalog = Student; Integrated Security = True";
            SqlConnection c = new SqlConnection(con);

            c.Open();
            string q = "Insert into Demo values(@id,@name,@age)";
            SqlCommand s = new SqlCommand(q, c);
            //insert
            s.Parameters.AddWithValue("@id", 252);
            s.Parameters.AddWithValue("@name", "Sarah");
            s.Parameters.AddWithValue("@age", 25);
            s.ExecuteNonQuery();
            //retrieve
            q = "Select * from Demo";
            s = new SqlCommand(q, c);
            SqlDataReader d = s.ExecuteReader();
            while (d.Read())
            {
                Console.WriteLine(d[0].ToString() + " " + d[1].ToString() + " " + d[2].ToString());
            }
            Console.ReadKey();
        }
    }
}

