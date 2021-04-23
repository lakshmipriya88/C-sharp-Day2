using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
   class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
    }
    class Class7
    {
        static void Main()
        {
            Employee emp = new Employee();
            emp.EmployeeID = 101;
            emp.Name = "Dummy1";
            Employee emp2 = new Employee();
            emp.EmployeeID = 102;
            emp.Name = "Dummy2";
            string a = "Lakshmi";
            string b = "Lakshmi";
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(Equals(a, b));
            Console.ReadLine();
        }
    }
   
}
