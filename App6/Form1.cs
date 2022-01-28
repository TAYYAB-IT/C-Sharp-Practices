using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App6
{
    public partial class Input_window : Form
    {
        public Input_window()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            if(roll_no.Text!="" && name.Text!="" && age.Text != "" && gender.Text != ""){
                student.setters(roll_no.Text, name.Text, Int32.Parse(age.Text), gender.Text);
                Show_window show_Window = new Show_window();
                show_Window.print(student);
                this.Hide();
                show_Window.Show();
            
            }
            else
            {
                MessageBox.Show("Something Missing!");
            }

        }
    }
}
