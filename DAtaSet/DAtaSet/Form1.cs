using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DAtaSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"data source=LUCKY;initial catalog=AdventureWorksDW2019;" + "Integrated Security=true;");
        SqlDataAdapter ad1,ad2;
        DataSet ds = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            ad1 = new SqlDataAdapter("select * from DimEmployee;",con);
            ad2 = new SqlDataAdapter("select * from DimCustomer;",con);
            ad1.Fill(ds, "Employee");
            ad2.Fill(ds, "Customer");
            dataGrid1.DataSource = ds;
        }
    }
}
