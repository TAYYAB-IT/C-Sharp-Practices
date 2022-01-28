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
    public partial class Show_window : Form
    {
        public Show_window()
        {
            InitializeComponent();
        }
        public void print(Student std)
        {
            result.Text = $" Welcome Mr.{std.get_name()} !" +
                $"\n Roll No# {std.get_id()}" +
                $"\n Gender::{std.get_gender()}" +
                $"\n Age::{std.get_age()}";
        }

        private void exit_Click(object sender, EventArgs e)
        {
           Input_window input_Window = new Input_window();
            this.Hide();   
            input_Window.Show();
        }
    }
}
