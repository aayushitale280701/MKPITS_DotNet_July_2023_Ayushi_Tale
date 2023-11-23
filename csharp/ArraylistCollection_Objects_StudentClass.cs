using System;
using System.Collections;
namespace objectStudentClass
{
    class Student
    {
        public int rollno;
        public string name;
        public Student(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(12,"Ayushi");
            Student s2 = new Student(13,"Om");
            Student s3 = new Student(14, "Khushi");
            ArrayList ar = new ArrayList();
            ar.Add(s1);
            ar.Add(s2);
            ar.Add(s3);
            foreach(Student s in ar)
            {
                Console.WriteLine("Student Name:  "+s.name);
                Console.WriteLine("Student RollNo:  " + s.rollno);
            }
            Console.ReadLine();

        }
    }
}