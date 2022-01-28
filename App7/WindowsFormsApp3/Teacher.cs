using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
   public class Teacher
    {
        private int emp_code;
        private string name;
        private Student[] student;
        private Course[] course;
        private int i;
        private int j;
        public Teacher() {
           
        }
        public Teacher(int student_length,int course_length)
        {
           this. student = new Student[student_length];
           this. course= new Course[course_length];
        }
        public void setters(int emp_code,string name)
        {
            this.emp_code = emp_code;
            this.name = name;
          
            this.i = 0;
            this.j = 0;
        }
        public void add_student(int roll,string name,string section)
        {
            if (this.i < this.student.Length)
            {
                this.student[this.i]=new Student();
                this.student[this.i].setters(roll, name, section);
               this. i++;
            }
            
        }

        public void add_course(int code,string name)
        {
            if (this.j <this.student.Length)
            {
                this.course[this.j] = new Course();
             this.course[this.j].setters(name,code);
              this.  j++;
            }

        }
        public string get_name()
        {
            return this.name;
        }
        public Student get_student(int roll)
        {
            for (int i = 0; i < this.i; i++)
            {
                if (this.student[i].get_roll() == roll)
                {
                    return student[i];
                }
            }
            return new Student();
        }
         public Course get_courses(int code)
        {
            for (int i = 0; i < this.j; i++)
            {
                if (this.course[i].get_code() == code)
                {
                    return course[i];
                }
            }
            return new Course();

        }
    }

}
