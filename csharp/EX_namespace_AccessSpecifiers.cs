using System;
namespace Enpasulation
{
    class Employee
    {
        public string empname { get; set; }
        public int id {  get; set; }
        public string email {  get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            // Setting values to the properties  
            emp.empname = "Ayushi";  
            emp.id = 234;
            emp.email = "Ayushi123@gmail.com";
            // getting values  
            Console.WriteLine("Name of Employee- " + emp.empname);
            Console.WriteLine("Email of Employee- "+emp.id);
            Console.WriteLine("Employee of ID- " + emp.email);
            Console.ReadKey();
        }
    }
}