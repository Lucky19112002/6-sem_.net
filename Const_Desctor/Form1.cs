using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Const_Desctor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class A
        {
            public A()
            {
                MessageBox.Show("This is constructuor");
            }
            ~A()
            {
                MessageBox.Show("This is Desctuctor");
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            A aobj = new A();
        }
    }
}
