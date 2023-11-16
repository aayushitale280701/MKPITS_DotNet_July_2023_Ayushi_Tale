using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatebasederivedClass
{
    public class Person
    {
        public String name;
        public String address;
    }
    public class Student : Employee
    {
        public int empno;
        public int salary;
        public string designation;
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Student p1 = new Student();//creating object of child class\
            p1.empno = 123;
            p1.name = "Ayushi";
            p1.address = "Mumbai";
            p1.salary = 50000;
            p1.designation = "HR";

            Console.WriteLine("Employee No: " + empno);
            Console.WriteLine("Name: " + p1.name);
            Console.WriteLine("Address: " + p1.address);
            Console.WriteLine("Salary: " + p1.salary);
            Console.WriteLine("Designation: " + p1.designation);
            Console.ReadLine();

        }
    }
}
