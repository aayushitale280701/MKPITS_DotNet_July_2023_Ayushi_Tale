using System;
namespace ExConstructorDistructor
{
    class Employee
    {
        public Employee()
        {
            Console.WriteLine("Constuctor Called");
        }
        ~Employee()
        {
            Console.WriteLine("Distructor Called");
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            Employee e = new Employee();
            Console.ReadKey();
            Employee e2 = new Employee();
            Console.ReadKey();
        }
    }
}