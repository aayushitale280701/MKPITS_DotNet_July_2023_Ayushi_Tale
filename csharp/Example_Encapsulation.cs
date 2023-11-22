using System;
namespace Enpasulation
{
    class Employee
    {
        public string empname { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.empname = "Ayushi"; //this will call setter 
            Console.WriteLine("Name of Employee- " + emp.empname);
            Console.ReadKey();
        }
    }
}