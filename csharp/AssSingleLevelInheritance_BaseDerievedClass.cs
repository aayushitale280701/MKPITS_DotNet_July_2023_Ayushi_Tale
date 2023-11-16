using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatebasederivedClass
{
    public class person
    {
        public String name;
        public String address;
    }
    public class employee : person
    {
        public int empno;
        public int salary;
        public string designation;
    }
    class Program
    {
        public static void Main(string[] args)
        {
            employee e1 = new employee(); //creating object of child class
            e1.empno = 123;
            e1.name = "Ayushi";
            e1.address = "Mumbai";
            e1.salary = 50000;
            e1.designation = "HR";

            Console.WriteLine("Employee No: " + e1.empno);
            Console.WriteLine("Name: " + e1.name);
            Console.WriteLine("Address: " + e1.address);
            Console.WriteLine("Salary: " + e1.salary);
            Console.WriteLine("Designation: " + e1.designation);
            Console.ReadKey();
        }
    }
}
