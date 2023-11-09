using System;
namespace MoreMethodClass
{
    class Book
    {
        public static void display()
        {
            Console.WriteLine("Hello");
        }
        public void Ayushi()
        {
            Console.WriteLine("Hii");
        }
    }
    class Program
    {
        //creating nonstatic display method
        static void Main(string[] args)
        {
            Book.display();

            //    student.sayhi();// error

            Book b = new Book();
            b.Ayushi();
        }
    }
}