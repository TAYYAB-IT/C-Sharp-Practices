using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
  public class Course
    {
        private string course_name;
        private int course_code;
        public Course()
        {
            this.course_code = 0;
            this.course_name = "None";
        }
        public void setters(string name, int code)
        {
            this.course_code = code;
            this.course_name = name;
        }
       
        public string get_name()
        {
            return this.course_name;
        }
        public int get_code()
        {
            return this.course_code ;
        }

    }
}
