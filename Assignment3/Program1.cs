using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program1
    {
        class student
        {
            public string name;
            public int roll_number;
            public void displaydetails()
            {
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Roll Number: " + roll_number);
               
            }
        }
        static void Main(string[] args)
        {
            student a=new student();
            a.name = "Reshmi";
            a.roll_number = 101;
            student b=new student();
            b.name = "Rahul";
            b.roll_number = 102;
            a.displaydetails();
            b.displaydetails();
            Console.ReadLine();
            
        }
    }
}
