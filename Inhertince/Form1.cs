using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inhertince
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Father
        {
            public void Mruticar()
            {
                MessageBox.Show("Maruti Carr....");
            }
        }
        class son : Father
        {
            public void BMWCar()
            { 
                MessageBox.Show("BMW Carr....");
            }
        }
        class grandson : son
        {
            public void MarcCar()
            {
                MessageBox.Show("Mercdes Banz Carr....");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            grandson Gs = new grandson();
            Gs.BMWCar();
            Gs.MarcCar();
            Gs.Mruticar();

        }
    }
}
