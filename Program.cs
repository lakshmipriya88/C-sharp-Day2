using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    class Program
    {
        void CheckOddEven(int a)
        {
           if (a % 2 == 0)
            {
                Console.WriteLine("A is even");
            }
           else
            {
                Console.WriteLine("A is odd");
            }

        }
        static void Main()
        {
            Program Program1 = new Program();
            Program1.CheckOddEven(6);
            Console.ReadLine();
        }

    }
}
