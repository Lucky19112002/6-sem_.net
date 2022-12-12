using System;
using System.Windows.Forms;

namespace Static_Variable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class JointAcccount
        {
            static int bal = 10000;
            public void widhraw(int amt)
            {
                bal = bal - amt;
                MessageBox.Show("Current balance is " + bal);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            JointAcccount obj1 = new JointAcccount();
            obj1.widhraw(Convert.ToInt32(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JointAcccount obj2 = new JointAcccount();
            obj2.widhraw(Convert.ToInt32(textBox1.Text));
        }
    }
}
