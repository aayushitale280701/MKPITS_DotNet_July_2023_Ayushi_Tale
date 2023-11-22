using System;
namespace protectedaccess
{
    class Student
    {
        protected string name;
        public void getdata()
        {
            name = "Ayushi";
            Console.WriteLine("Name:- "+name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.getdata();
        }
    }
}