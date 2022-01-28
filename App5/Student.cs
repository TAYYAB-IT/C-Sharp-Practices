using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    internal class Student
    {
        private string id;
        private string name;
        private int age;
        private string cnic;
        private string city;
        private string country;
        //Setters
        public void set_id(string id)
        {
            this.id = id;
        }
        public void set_name(string name)
        {
            this.name = name;
        }
        public void set_age(int age)
        {
            this.age = age;
        }
        public void set_cnic(string cnic)
        {
            this.cnic = cnic;
        }
        public void set_city(string city)
        {
            this.city = city;
        }
        public void set_country(string country)
        {
            this.country= country;
        }
        //Getters
        public string get_id()
        {
            return this.id;
        }
        public string get_name()
        {
            return this.name;
        }
        public int get_age()
        {
           return this.age;
        }
        public string get_cnic()
        {
           return this.cnic ;
        }
        public string get_city()
        {
          return  this.city;
        }
        public string get_country()
        {
            return this.country;
        }

    }
}
