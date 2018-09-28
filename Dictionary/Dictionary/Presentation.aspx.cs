using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business;
using Student;

namespace Dictionary
{
    public partial class PresentationClass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StudentClass s1 = new StudentClass();
            s1.id = 14;
            s1.name = "Lee";
            s1.age = 24;
            StudentClass s2 = new StudentClass();
            s2.id = 12;
            s2.name = "Stephanie";
            s2.age = 23;
            BusinessClass b = new BusinessClass();
            b.InsertData(s1,s2);
        }
    }
    }
