//Implement Run Time Polymorphism


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Assignment2
    {
        public class User
        {
            public string name = "Dhanya";
            public string location = "kasargod";
            public int age = 23;
            public virtual void GetInfo()
            {

                Console.WriteLine("Name:{0}", name);
                Console.WriteLine("Location:{0}", location);

            }
        }
        public class Details : User
        {

            public override void GetInfo()
            {
                base.GetInfo();
                Console.WriteLine("Age:{0}", age);
            }
        }
        static void Main(string[] args)
        {

            Details d = new Details();
            d.GetInfo();
            Console.WriteLine("\npress any key to exit....");
            Console.ReadLine();
        }
    }
}
