/* using System;
namespace Tayyab
{
    class Address
    {
        public string city;
        public string state;
    }
    class Person:Address
    {
        public string name;
        public int age;
    }
    class Student : Person
    {
        public int id;
    }
    class Program
    {
        static void Main(string[] args)
        {

            Student std=new Student();
            Console.WriteLine("Name::");
            std.name=Console.ReadLine();
            Console.WriteLine("Age::");
            std.age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ID::");
            std.id= Int32.Parse(Console.ReadLine());
            Console.WriteLine("City::");
            std.city = Console.ReadLine();
            Console.WriteLine("State::");
            std.state = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Result");
            Console.WriteLine($"Name::{std.name}\nAge::{std.age}\nID::{std.id}\nCity::{std.city}\nState::{std.state}");
            Console.WriteLine("\nPress Any Key to Exit..");
            Console.ReadLine();
        }
    }
}


 */

/*  using System;
 namespace Program
 {
     class  Program
     {
         static void Main(string[] args){
             List<int> li=new List<int>(){1,2,3};
             li.Add(2);
             foreach(var i in li){
                 Console.WriteLine(i);
             }
         }
     }
 } */

/*  using System;

namespace Tutlane
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            //string st="hello";
            //st=st.ToUpper();
            Console.WriteLine(st);
            Multiplication(out x);
            Console.WriteLine("Variable Value: {0}", x);
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
        
        public static void Multiplication(out int a)
        {
            a = 10;
            a *= a;
        }
    }
} */

using System;
namespace Tayyab
{
    class Program{
        static void Main(string[] args){
            string exp="98-8";
            string[] operands=exp.Split('+');
            double ans=0;
            if(exp.Contains('+')){
               ans=solver(exp,'+');
            }
            else if(exp.Contains('-')){
                ans=solver(exp,'-');
            }
            else if(exp.Contains('*')){
                ans=solver(exp,'*');
            }
            else if(exp.Contains('/')){
                ans=solver(exp,'/');
            }
            else if(exp.Contains('%')){
                ans=solver(exp,'%');
            }
            Console.WriteLine(ans);
        }
    
     public static double solver(string exp,char operation){
        string[]operands=exp.Split(operation);
        if(operation=='+'){
            return double.Parse(operands[0])+double.Parse(operands[1]);
        }
        else if(operation=='-'){
            return double.Parse(operands[0])-double.Parse(operands[1]);
        }
         else if(operation=='*'){
            return double.Parse(operands[0])*double.Parse(operands[1]);
        }
         else if(operation=='/'){
            return double.Parse(operands[0])/double.Parse(operands[1]);
        }
         else if(operation=='%'){
            return double.Parse(operands[0])%double.Parse(operands[1]);
        }
            return 0;

    }
    }
}