using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            int[] arr = { 2, 3, 4, 5, 3, 1, 3, 2, 7};
            //Comment Code Block Ctrl+K+C/Ctrl+K+U
            //string str = "h,e,l,l,o";
            //string[] stra_arr = str.split(',');
            //foreach (string s in stra_arr)
            //{
            //    console.writeline(s);
            //}
            //Console.WriteLine(String.Join(",",arr));
            //  Array.Sort(arr);
            //  sort_array(arr);
            // Console.WriteLine((search_array(9, arr))? "Found":"Not Found");
            //reverse_array(arr);
            // Console.WriteLine("Write Something::");
            //string str = Console.ReadLine();
            //MessageBox.Show(str);
            //for (int i = 0; i < str.Length; i++)
            //{
            //    Console.WriteLine(str[i]);
            //}

            // Console.WriteLine(prime_count(arr));

            //  foreach (int i in arr)
            //{
            //   Console.WriteLine(i);

            //}

            //  faboncii_series(0,50);
            //   Console.WriteLine(reverse_number(1000));
            //  perfect_number();
           // math();
         //  expression_solver();
        }
        public static void expression_solver()
        {
            string exp="21+32";
            string[] operands=exp.Split('+');
            double ans=0;
            if(exp.Contains('+')){
                ans = solver(exp, '+');
            }
            else if(exp.Contains('-')){
                ans = solver(exp, '-');
            }
            else if(exp.Contains('*')){
                ans=solver(exp,'*');
            }
            else if(exp.Contains('/')){
                ans=solver(exp,'/');
            }
            else if(exp.Contains('%')){
                ans = solver(exp, '%');
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
        
       //SQrt
       public static void math()
        {
            Console.WriteLine(Math.Sqrt(289));
            // Console.WriteLine(Math.Pow(2, 3));
            //Power
            int ba = 2, pow = 8;
            int ans=1;
            for(int i = 0; i <= pow; i++)
            {
                if (i == 0)
                {
                    ans *= 1;
                }
                else
                {
                    ans *= ba;
                }
            }
            Console.WriteLine(ans);
            //Factorial
            int n = 1;
            int res = 1;
           for(int i = 0; i <= n; i++)
            {
                if (i ==0)
                {
                    res *= 1;
                }
                else
                {
                    res *= i;
                }
            }
            Console.WriteLine(res);
        }
        //reverse a number
        public static int reverse_number(int n)
        { 
            int res=0;
            while (n !=0) {
                res *= 10;
                res += n % 10;
                n = n / 10;
            
            }
            return res;
        }
        //Perfect numbers series
        public static void perfect_number(int start = 1,int end = 500)
        {
            for(int i=start;i<end;i++){
                int result = 0;
                for(int j = 1; j <= i / 2; j++)
                {
                    if (i % j == 0) {
                        result += j;
                    }
                }
                if (result == i)
                {
                    Console.WriteLine(i);
                }
            }

        }
    //Faboncii Series
    public static void faboncii_series(int start = 0,int end=100)
        {
            int i = 0, x = 1, z;
            while (i <= end)
            {
                z = i;
                if(i>=start)
                Console.WriteLine(i);
                i += x;
                x = z;
                

            }
        }


        // count prime
        public static int prime_count(int[] arr)
        {
            int count=arr.Length;
            foreach(int i in arr)
            {
                if (i == 1)
                {
                    count--;
                    continue;
                }
                for(int j = 2; j <= i / 2; j++)
                {
                    if(i % j == 0 )
                    {
                        count--;
                        break;
                    }
                }
            }
            return count;
        }


        //Reverse Array
        public static void reverse_array(int[]arr)
        {
            for(int i = 0; i <arr.Length/2; i++)
            {
                int x = arr[arr.Length - (i + 1)];
                arr[arr.Length - (i + 1)] = arr[i];
                arr[i] = x;
            }
        }

        //Searching Array
        public static bool search_array(int value,int[] arr)
        {
           
            foreach(int i in arr)
            {
                if(value == i)
                {
                    return true;
                   
                }
            }
            return false;

        }
        //Sorting Array
        public static void sort_array(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for(int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int x = arr[i];
                        arr[i]=arr[j];
                        arr[j]=x;
                    }
                }
            }

        }
    }
}
