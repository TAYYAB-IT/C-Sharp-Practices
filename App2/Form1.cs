using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            
            if (op1.Text != "" && op2.Text != "") { 

                operation.Text = "+";
            result.Text = (Int64.Parse(op1.Text) + Int64.Parse(op2.Text)).ToString();
            }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            
            if (op1.Text != "" && op2.Text != "")
            {
                operation.Text = "-";
                result.Text = (Int64.Parse(op1.Text) - Int64.Parse(op2.Text)).ToString();
            }
        }

        private void mul_Click(object sender, EventArgs e)
        {
            
            if (op1.Text != "" && op2.Text != "")
            {
                operation.Text = "x";
                result.Text = (Int64.Parse(op1.Text) * Int64.Parse(op2.Text)).ToString();
            }
        }

        private void div_Click(object sender, EventArgs e)
        {

            if (op1.Text != "" && op2.Text != "")
            {
                operation.Text = "/";
                result.Text = (float.Parse(op1.Text) / float.Parse(op2.Text)).ToString();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            op1.Text = op2.Text = result.Text =operation.Text= "";
        }
    }
}
