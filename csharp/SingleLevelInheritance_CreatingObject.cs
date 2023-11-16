using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace creatingObject
{
    public class Person
    {
        public String name;
        public String address;
    }
    public class Student : Person
    {
        public int rno;
        public int marks;
    }
    class TestInheritance
    {
        public static void Main(string[] args)
        {
            Student p1 = new Student();//creating object of child class
            p1.rno = 123;
            p1.name = "Ayushi";
            p1.address = "Mumbai";
            p1.marks = 888;

            Console.WriteLine("Rno: " + p1.rno);
            Console.WriteLine("Name: " + p1.name);
            Console.WriteLine("Address: " + p1.address);
            Console.WriteLine("Marks: " + p1.marks);

        }
    }
}