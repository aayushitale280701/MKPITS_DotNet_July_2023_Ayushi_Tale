using System;
namespace ex_inheritance
{
    //Creating a base class person

    class person
    {
        public string name;
    }
    //Creating a derieved class student

    class student : person
    {
        public int rno;
    }
    class Program
    {
        public static void Main (string[] args)
        {
            student s = new student();
            s.rno = 222;
            s.name = "Ayushi";
            Console.WriteLine("Roll No:- "+s.name);
            Console.WriteLine("Name:- "+s.rno);
            Console.ReadKey();
        }
    }
}