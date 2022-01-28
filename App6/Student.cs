using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App6
{
    public  class Student        //must create it public if you want to acces it in mutlwindows.
    {
        private string name;
        private int age;
        private string  id;
        private string gender;
        public void setters(string id,string name,int age,string gender)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;

        }
        public string get_id()
        {
            return this.id;
        }
        public string get_name()
        {
            return this.name; 
        }
        public string get_gender()
        {
            return this.gender;
        }
        public int get_age()
        {
            return this.age;
        }
    }
}
