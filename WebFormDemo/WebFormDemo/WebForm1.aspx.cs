using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string con = "Data Source=G1C2ML18279;Initial Catalog=Security;Integrated Security=True";
            SqlConnection c = new SqlConnection(con);
            c.Open();
            string q = "Insert into Webform values(@Id,@Name,@Age)";
            SqlCommand s = new SqlCommand(q, c);
            s.Parameters.AddWithValue("@Id", TextBox1.Text);
            s.Parameters.AddWithValue("@Name", TextBox2.Text);
            s.Parameters.AddWithValue("@Age", TextBox3.Text);
            s.ExecuteNonQuery();
            c.Close();
        }
    }
}