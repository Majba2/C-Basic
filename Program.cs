using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int sum = 0;  //global scope declare for question 1(c)
        static void Main(string[] args)
        {
            //1.a all decision and itteration
            //if-else
            int marks = 33;
            if (marks>33)
            {
                Console.WriteLine("Pass");
            }
            else 
            {
                Console.WriteLine("status:Fail");
            }
            //switch
            int person = 0;
            switch (person) 
            
            {
                    case 1:
                    Console.WriteLine("Hridoy");
                    break;
                    case 2:
                    Console.WriteLine("Habib");
                    break;
                    case 3:
                    Console.WriteLine("Fahim");
                    break;  
                    default:
                    Console.WriteLine("Majba");
                    break;
            }
            //while
            int k = 0;
            while (k <= 5) 
            {
             Console.WriteLine($"While loop:" +k);
                k++;
            }
            //for
            for (int i = 0; i < 10; i++) 
            {
             Console.WriteLine($"For loop:"+i);
            }
            //do while
            int c = 0;
            do 
            {
             Console.WriteLine($"Do while loop:"+c);
                c++;
            }
            while (c < 10);
            //Question :1.b 
            int x = 20;
            int y = 10;
            int results = 0;
            Console.WriteLine("Arithmetic Operator");
            results = (x+y);
            Console.WriteLine($"Sum:"+results);
            results = (x - y);
            Console.WriteLine($"Sub:" + results);
            results = (x * y);
            Console.WriteLine($"Multiplication:" + results);
            results = (x / y);
            Console.WriteLine($"Division:" + results);
            results = (x % y);
            Console.WriteLine($"Modulas:" + results);
            //diferernce between suffix prefix
            int a = 4;
            int b = a++ + 6;
            c = b++;
            Console.WriteLine($"Value of A is:"+a);
            Console.WriteLine($"Value of B is:" + b);
            Console.WriteLine($"Value of C is:" + c);
            // diference between while and do while
            ////while(before the execution the condition will be checked)
            //int k = 0;
            //while (k <= 5)
            //{
            //    Console.WriteLine($"While loop:" + k);
            //    k++;
            //}
            //do(after excetuion of one time then condition will be checked)
            //{
            //    Console.WriteLine($"Do while loop:" + c);
            //    c++;
            //}
            //while (c < 10);
            //Question 1:d-

            int d=int.MaxValue;  //checked unchcked
            unchecked
            { 
             Console.WriteLine($"value:"+(d+3));
            }
            try
            {
                checked 
                {
                 Console.WriteLine($"value:" + (d + 3));
                }

            }
            catch(OverflowException ex)
            {
                Console.WriteLine($"reson:"+ex.Message);
            }
            //Question; 1-e(try-catch-finally)
            int t = 0;   
            int div = 0;
            try
            {
                 div = 100 / t;
                Console.WriteLine("This is not possible");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message); 
            }
            finally 
            { 
             Console.WriteLine("Finally block this");
            }
            // question 1.c
          
            AddStudent(studentName: "Majba", subject: "CSE");  //Named Arguments
             Math(7, 2);
            Console.WriteLine(sum);

            var TspAddress = ("USSL", 1250, "Dhaka"); //tupple
            Console.WriteLine(TspAddress);
            Console.ReadLine();
        }
         
        static void Math(int num1, int num2) // method
        {
            int total = num1 + num2; // total is local scope variable
            sum = total;
            Console.WriteLine("{0} + {1}" , num1, num2, total);

        }

        static void AddStudent(string studentName, string subject = "EEE") // subject is optional param
        {
            Console.WriteLine("Student Name = {0}, Subject = {1}", studentName, subject);
        }
    }

}

