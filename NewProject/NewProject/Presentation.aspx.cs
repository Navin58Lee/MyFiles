using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
namespace NewProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            BusinessClass d = new BusinessClass();
            d.CallInsert(TextBox1.Text,TextBox2.Text,TextBox3.Text);
        }
       /* protected void Button2_Click(object sender, EventArgs e)
        {
           
        }*/
    }
}