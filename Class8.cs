using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    class Class8
    {
        static void Main()
        {
            object str = "hello";
            char[] values = { 'h', 'e', 'l', 'l', 'o' };
            object str2 = new string(values);
            Console.WriteLine("Using Equality operator " + (str == str2));
            Console.WriteLine("Using equals() method {0}", str.Equals(str2));
            Console.ReadLine();
        }
    }
}
