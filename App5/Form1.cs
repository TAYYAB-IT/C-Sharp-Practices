using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student std=new Student();
            std.set_id(rollno.Text);
            std.set_name(name.Text);
            std.set_cnic(cnic.Text);
            std.set_age(Int32.Parse(age.Text));
            std.set_city(city.Text);
            std.set_country(country.Text);
            reception.Text=$"Name::{std.get_name()}\n" +
                $"Roll No::{std.get_id()}\n" +
                $"CNIC#::{std.get_cnic()}\n" +
                $"Age::{std.get_age()}\n" +
                $"City::{std.get_city()} \n" +
                $"Country::{std.get_country()}";
            reception.Visible=true;

        }
    }
}
