using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Form_Server_Side_Valideator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string meals = "";
            if (chk1.Checked == true)
                meals = meals + chk1.Text;

            if (chk2.Checked == true)
                meals = meals + chk2.Text;

            if (chk3.Checked == true)
                meals = meals + chk3.Text;

            string va = "";
            va = RadioButtonList1.SelectedValue;

            string vaccinName = ddlVaccineName.SelectedValue;

            Response.Write("<h1 style='color:green'>Name: " + name + "</h1>");
            Response.Write("<h1  style='color:red'>Meals " + meals + "</h1>");
            Response.Write("<h1  style='color:pink'>Vaccination Status " + va + "</h1>");
            Response.Write("<h1  style='color:maroon'>Vaccine Name " + vaccinName + "</h1>");
        }
    }
}