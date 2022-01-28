using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Maximum_Click(object sender, EventArgs e)
        {
            double value1 = double.Parse(Box1.Text);
            double value2 = double.Parse(Box2.Text);
            double value3 = double.Parse(Box3.Text);
            if(value1>value2&& value1 > value3) { MessageBox.Show("Box 1 has Max value"); }
            else if (value2 > value1 && value2 > value3) { MessageBox.Show("Box 2 has Max value"); }
            else if(value3>value2 &&value3>value2) { MessageBox.Show("Box 3 has Max value"); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
