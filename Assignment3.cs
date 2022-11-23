//Program to create a function to input a string and count the number of spaces in the string.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Assignment3
    {
		public static int SpaceCount(String str)
		{
			
			int s = 0;
			foreach (char c in str)
			{
				if (c == ' ')
				{
					s++;
				}
			}
			return s;
		}
		static void Main(string[] args)
        {
			string str;
			Console.Write("Please Enter a string : ");
			str = Console.ReadLine();			
			Console.WriteLine(" String contains {0} spaces",+SpaceCount(str));
			Console.ReadKey();
		}
    }
}
