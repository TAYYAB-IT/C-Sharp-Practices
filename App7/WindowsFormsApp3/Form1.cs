using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(4,4);//pass maximum student & maximum courses 
            teacher.setters(Int32.Parse(emp_code.Text), name.Text);
            this.Hide();
            Form2 form2 = new Form2(teacher);
            form2.Show();
        }
    }
}
