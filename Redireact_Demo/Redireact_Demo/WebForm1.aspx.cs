using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Redireact_Demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text=="lucky" && TextBox2.Text=="lucky")
            {
                Response.Redirect("INBOX.aspx");
            }
            else
            {
                Response.Write("Invalid User");
            }
        }
    }
}