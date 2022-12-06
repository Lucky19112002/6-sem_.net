using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Object_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Employee
        {
            int empid;
            string name;
            int sal = 10000;
            int bonuse = 200;
            public void tsal()
            {
                MessageBox.Show("The total salery is " + (sal + bonuse));
            }
        }
        private void button1_click(object sender,EventArgs e)
        {
            int sal = Convert.ToInt32(textBox1.Text);
        }

    }
}
