using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Database
{
    public class Class1
    {
        public object GridView1 { get; private set; }

        public void InsertData(string id,string name,string age)
        {
            string con = "Data Source=G1C2ML18279;Initial Catalog=NewDatabase;Integrated Security=True";
            SqlConnection c = new SqlConnection(con);
            c.Open();
            string q = "Insert into Newtable values(@id,@name,@age)";
            SqlCommand s = new SqlCommand(q, c);
            s.Parameters.AddWithValue("@id",id);
            s.Parameters.AddWithValue("@name",name);
            s.Parameters.AddWithValue("@age", age);
            s.ExecuteNonQuery();
            c.Close();
        }
        /*public void RetrieveData(string id,string name,string age)
        {
            string con = "Data Source=G1C2ML18279;Initial Catalog=NewDatabase;Integrated Security=True";
            SqlConnection c = new SqlConnection(con);
            c.Open();
            string q = "Select *from Example_Table1";
            SqlCommand q1 = new SqlCommand(q, c);
            SqlDataAdapter dataAdapt = new SqlDataAdapter(q, con);
            DataSet d = new DataSet();
            dataAdapt.Fill(d);
            GridView1.DataSource = d;
            GridView1.DataBind();
            c.Close();
        }*/
    }
}
