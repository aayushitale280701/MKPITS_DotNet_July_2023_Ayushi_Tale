using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HierarchicalInheritance
{
    class person
    {
        public string name;
        public string address;

    }
    class student : person
    {
        public int rno;
        public int marks;

    }
    class employee : person
    {
        public int salary;
        public string designation;
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.name = "Ayushi";
            s.address = "Nagpur";
            s.rno = 44;
            s.marks = 999;
            Console.WriteLine("---------------Student Details ----------");
            Console.WriteLine("Name: " + s.name);
            Console.WriteLine("Addres: " + s.address);
            Console.WriteLine("Rno: " + s.rno);
            Console.WriteLine("Marks: " + s.marks);
            //creating object of empclass
            employee emp = new employee();
            emp.name = "Rajesh";
            emp.address = "Mumbai";
            emp.salary = 55544;
            emp.designation = "Manager";
            Console.WriteLine("---------------Emp Details ----------");
            Console.WriteLine("Name: " + emp.name);
            Console.WriteLine("Addres: " + emp.address);
            Console.WriteLine("Salary: " + emp.salary);
            Console.WriteLine("Designation: " + emp.designation);
            Console.ReadKey();
        }
    }
}
