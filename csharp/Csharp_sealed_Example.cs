using System;
namespace Sealedexample
{
    abstract class Person
    {
        public string name;
    }
    class Student : Person
    {
        public int rno;
    }

    sealed class Parttimestudent : Student
    {
        public int hours;
    }
    class program
    {
        static void Main(string[] args)
        {
            Parttimestudent p = new Parttimestudent();
            p.rno = 11;
            p.hours = 5;
            p.name = "Ayushi";
            Console.WriteLine("Student Name: " + p.name);
            Console.WriteLine("Student Rno: " + p.rno);
            Console.WriteLine("Student Hours: " + p.hours);
            Console.ReadKey();
        }
    }
}