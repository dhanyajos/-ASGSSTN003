// Create a class student with attribute name and roll number and a method displaydetails() 
//for displaying the same.Create two instance of the class and call the method for each instance



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Student
    {
       
            private string name;
            private int rollno;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int rollNo
            {
                get { return rollno; }
                set { rollno = value; }
            }

            public void displaydetails()
            {
                Console.WriteLine("Name:" + Name);
                Console.WriteLine("RollNo:" + rollNo);
            }
        }
        class Assignment1
        {
            static void Main(string[] args)
            {
                Student s1 = new Student();
                Student s2 = new Student();

                s1.Name = "Dhanya";
                s1.rollNo = 1001;
                s1.displaydetails();
                s2.Name = "Josna";
                s2.rollNo = 1002;
                s2.displaydetails();
                Console.ReadLine();

            }
        }

    }