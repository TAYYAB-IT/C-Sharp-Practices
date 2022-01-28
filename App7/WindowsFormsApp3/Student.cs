using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
  public  class Student
    {
        private int   roll_no;
        private string name;
        private string section;
        public Student()
        {
            this.roll_no = 0;
            this.name = "None";
            this.section = "None";
        }
        public void setters(int roll,string name,string section)
        {
            this.roll_no = roll;
            this.name = name;
            this.section = section;
        }
        public int get_roll()
        {
            return this.roll_no;
        }
        public string get_name()
        {
            return this.name;
        }
        public string get_section()
        {
            return this.section;
        }
    }
}
