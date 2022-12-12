using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Error_Handling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = a / b;
                textBox3.Text = c.ToString();
            }
            catch(DivideByZeroException cc)
            {
                MessageBox.Show("Dont Enter Zero As Divisor" + cc.Message);
            }
            catch(FormatException cc)
            {
                MessageBox.Show("Dont Enter Alphabate As Divisor" + cc.Message);
            }
            catch(Exception cc)
            {
                MessageBox.Show("Some Error Accured.\n Please Restart Process" + cc.Message);
            }
            finally
            {
                MessageBox.Show("I am Still Alive");
            }
        }

        class Axicebank:ApplicationException
        {
            public Axicebank(string message):base(message)
            {

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int age = Convert.ToInt32(textBox4.Text);
                if (age<18)
                {
                    throw new Axicebank("Not eligibale");
                }
            }
            catch(Axicebank ec)
            {
                MessageBox.Show(ec.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
