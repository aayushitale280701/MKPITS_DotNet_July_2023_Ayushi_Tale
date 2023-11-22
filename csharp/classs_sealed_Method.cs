using System;
namespace sealedMethod
{
   class Person
    {
        public virtual void dispaly()
        {
            Console.WriteLine("Hello from person");
        }
    }
    class Student : Person
    {
        public string name;
        public sealed override void dispaly()
        {
            Console.WriteLine("Hello from second class");
        }
    }
    class Parttime : Student
    {
        /*
        public  override void display() //error since sealed
        {
            Console.WriteLine("hello");
        }
        */
    }

    class program
    {
        static void Main(string[] args)
        {
            Parttime p = new Parttime();   
            p.dispaly();
            Console.ReadKey();
        }
    }
}