using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string con = "Data Source=G1C2ML18279;Initial Catalog=Sunday;Integrated Security=True";
            //string con = "Data Source=G1C2ML18279;Initial Catalog=Sunday;Integrated Security=True";
            SqlConnection c = new SqlConnection(con);
            c.Open();
            string q = "Select *from Table_1";
            SqlCommand q1 = new SqlCommand(q, c);
            SqlDataAdapter dataAdapt = new SqlDataAdapter(q, con);
            DataSet d = new DataSet();
            dataAdapt.Fill(d);
            GridView1.DataSource = d;
            GridView1.DataBind();
            c.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string con = "Data Source=G1C2ML18279;Initial Catalog=Sunday;Integrated Security=True";
            SqlConnection c = new SqlConnection(con);
            c.Open();
            string q = "Insert into Table_1 values(@id,@name)";
            SqlCommand s = new SqlCommand(q, c);
            s.Parameters.AddWithValue("@id", TextBox1.Text);
            s.Parameters.AddWithValue("@name", TextBox2.Text);
            s.ExecuteNonQuery();
            c.Close();
        }
    }
}