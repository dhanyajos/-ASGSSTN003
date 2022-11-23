﻿//Perform Stack Operations



using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Assignment4
    {
        static void Main(string[] args)
        {
            Stack stk = new Stack();
            stk.Push(1);
            stk.Push(2);
            stk.Push(3);
            stk.Push("dhanya");
            Console.WriteLine("Stack items before pop");
            foreach (var obj in stk)
            {
                Console.WriteLine(obj);
            }
            stk.Pop();
            stk.Pop();

            Console.WriteLine("Stack items after pop");
            foreach (var obj in stk)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
            Console.WriteLine("The number of elements in the stack: " + stk.Count);
            Console.WriteLine("Does the stack contain the element 1: " + stk.Contains(1));
            Console.WriteLine("Peek element:"+ stk.Peek());
            Console.ReadKey();
        }
    }
}
