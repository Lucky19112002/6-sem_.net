using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Redireact_Demo
{
    public partial class INBOX : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("<marquee><h1>Welocme</h1></marquee>");
            for (int i = 0; i < 10000; i++)
            {
                Response.Write("<img src=Luckypacher.png />");
            }
        }
    }
}