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
    public partial class Form2 : Form
    {
        private Teacher teacher;
        public Form2(Teacher teacher)
        {
            InitializeComponent();
            this.teacher = teacher;
            teacher_name.Text = this.teacher.get_name();
        }
        //Exit button
        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            this.Hide();
            form1.Show();
        }
        //Add Student
        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(teacher);
            this.Hide();
            form3.Show();
        }
        //show student
        private void button2_Click(object sender, EventArgs e)
        {
            string res_text="";
            if (roll.Text != "")
            {

                Student std = this.teacher.get_student(Int32.Parse(roll.Text));

                if (std.get_roll() != 0)
                {
                    res_text += $"Roll # {std.get_roll()}\n Name::{std.get_name()}\n Section::{std.get_section()}\n\n";
                }
                else
                {
                    res_text += "No Result";
                }

                Form5 form5 = new Form5(res_text);
                form5.Show();
            }
        }
        //Show course
        private void button4_Click(object sender, EventArgs e)
        {
            string res_text = "";
            if (code.Text != "")
            {
                Course cr = this.teacher.get_courses(Int32.Parse(code.Text));
                
                    if (cr.get_code() != 0)
                    {
                        res_text += $"Course Code:: {cr.get_code()}\n Title::{cr.get_name()}\n\n\n";
                    }
                else
                {
                    res_text += "No Result";
                }
                
                Form5 form5 = new Form5(res_text);
                form5.Show();

            }
        }
        //Add Course
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this.teacher);
            this.Hide();
            form4.Show();
        }
    }
}
