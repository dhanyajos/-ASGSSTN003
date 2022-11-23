////using Classes and Object. Implement the following facilities using C#.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Assignment5
    {
        class Book
        {
            private int BOOKNO;
            private string BOOKTITLE;
            private float PRICE;

            public void INPUT()
            {
                Console.Write("Enter the Book No: ");
                BOOKNO = int.Parse(Console.ReadLine());
                Console.Write("Enter the Book Title: ");
                BOOKTITLE = Console.ReadLine();
                Console.Write("Enter the Price: ");
                PRICE = int.Parse(Console.ReadLine());
            }

            private float TOTALCOST(int n)
            {
                return PRICE * n;
            }

            public void PURCHASE()
            {
                Console.Write("Enter the number of copies to be purchased: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Total cost to be paid: {0}", TOTALCOST(n));
            }

        }

            static void Main(string[] args)
            {
                Book b = new Book();
                b.INPUT();
                b.PURCHASE();
                Console.ReadLine();
            }
        
    }
}
