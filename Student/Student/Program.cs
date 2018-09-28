using System;
using System.Data.SqlClient;
namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string con = "Data Source = G1C2ML18279; Initial Catalog = Student; Integrated Security = True";
            SqlConnection c = new SqlConnection(con);

            c.Open();
            string q = "Insert into Student values(@id,@name,@age)";
            SqlCommand s = new SqlCommand(q, c);
            //insert
            s.Parameters.AddWithValue("@id", 234);
            s.Parameters.AddWithValue("@name", "Mike");
            s.Parameters.AddWithValue("@age", 34);
            s.ExecuteNonQuery();
            //retrieve
            q = "Select * from Student";
            s = new SqlCommand(q, c);
            SqlDataReader d = s.ExecuteReader();
            while (d.Read())
            {
                Console.WriteLine(d[0].toString()+" "+d[1].toString()+" "+d[2].toString());
            }

        }
    }
}
