using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    class Class4
    {
        void Swap(out int a, ref int b)
        {

            Console.WriteLine(" After swap fun");
            a = 0;

        }

        static void Main()
        {
            Class4 Class1 = new Class4();
            int a = 5, b = 6;
            Console.WriteLine("Inside Main fun");
            Console.WriteLine("a= " + a);
            Class1.Swap(out a, ref b);
            Console.WriteLine("a=" + a);

            Console.ReadLine();
        }
    }
}
