using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    class Class1
    {
        void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("---Inside swap function--");
            Console.WriteLine("a= " + a);
            Console.WriteLine("b= " + b);
        }
        static void Main()
        {
            Class1 Class = new Class1();
            int a = 5, b = 6;
            Class.Swap(a, b);
            Console.WriteLine("---Inside main function--");
            Console.WriteLine("a= " + a);
            Console.WriteLine("b= " + b);
            Console.ReadLine();
        }
    }
}
