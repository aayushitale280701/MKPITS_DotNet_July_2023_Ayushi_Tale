using System;
namespace accessModifier
{
    class Student
    {
        internal string name { get; set; }
        internal int rollno { get; set; }

        public void dispaly()
        {
            Console.WriteLine("Name:- "+name);
            Console.WriteLine("RollNo:- " + rollno);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.name = "Ayushi";
            s.rollno = 123;
            s.dispaly();
            Console.ReadKey();
        }
    }
}
