using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Business;
namespace Presentation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BusinessClass bc = new BusinessClass();
            int a = Convert.ToInt32(TextBox1.Text);
            int b = Convert.ToInt32(TextBox3.Text);
            bc.CallDataInsert(a, TextBox2.Text,b);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            BusinessClass bc = new BusinessClass();
            DataSet set = bc.CallDataRetrieve();
            GridView1.DataSource = set;
            GridView1.DataBind();
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}