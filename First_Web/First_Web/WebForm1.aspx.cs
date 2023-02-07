using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First_Web
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(TextBox1.Text);
            if (n<5000)
            {
                Response.Write("<h1>suoud be above 5000</h1>");
            }
        }
    }
}