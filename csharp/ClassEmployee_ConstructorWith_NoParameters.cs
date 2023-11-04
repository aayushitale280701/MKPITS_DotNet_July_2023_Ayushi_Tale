using System;
namespace classemp
{
    class Employee
    {
        int empno;
        string empname;
        string designation;
        int salary;

        //constructor with no parameters
        public Employee()
        {
            empno= 1;
            empname = "Ayushi";
            designation = "HR";
            salary = 50000;
        }
        public void dispaly()
        {
            Console.WriteLine("Employee No. = " +empno);
            Console.WriteLine("Employee Name = " + empname);
            Console.WriteLine("Designation = " + designation);
            Console.WriteLine("Employee Salary = "+ salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.dispaly();
            Console.ReadLine();
        }
    }
}