using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Example1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string con = "Data Source=G1C2ML18279;Initial Catalog=Sunday;Integrated Security=True";
            SqlConnection c = new SqlConnection(con);
            c.Open();
            string q = "Insert into Example_Table1 values(@id,@name,@age)";
            SqlCommand s = new SqlCommand(q, c);
            s.Parameters.AddWithValue("@id", TextBox1.Text);
            s.Parameters.AddWithValue("@name", TextBox2.Text);
            s.Parameters.AddWithValue("@age", TextBox3.Text);
            s.ExecuteNonQuery();
            c.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string con = "Data Source=G1C2ML18279;Initial Catalog=Sunday;Integrated Security=True";
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

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string con = "Data Source=G1C2ML18279;Initial Catalog=Sunday;Integrated Security=True";
            SqlConnection c = new SqlConnection(con);
            c.Open();
            string Age = "select sum(age) from Example_Table1";
            SqlCommand q2 = new SqlCommand(Age, c);
            Int32 total = Convert.ToInt32(q2.ExecuteScalar());
            TextBox4.Text = total.ToString();
            c.Close();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string con = "Data Source=G1C2ML18279;Initial Catalog=Sunday;Integrated Security=True";
            SqlConnection c = new SqlConnection(con);
            c.Open();
            string del = "Delete from Example_Table1 where name = @name";
            SqlCommand q3 = new SqlCommand(del, c);
            q3.Parameters.AddWithValue("@name", TextBox5.Text);
            q3.ExecuteNonQuery();
            c.Close();
        }
    }
}