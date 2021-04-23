using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    class Dog
    {
        public void Speak()
        {
            Console.WriteLine("Bark !");
        }
    }
    class Class6
    {
        static void Main()
        {
            Object o = new Dog();
            Dog dog = o as Dog;
            if (dog != null)
                dog.Speak();
            Console.ReadLine();
        }
    }
}
