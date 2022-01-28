using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Student : Form
    {
        public Student()
        {
            InitializeComponent();
        }
        private void submit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mr. " + name.Text + " Your Registration Form has been Submitted.");
        }
    }
}
