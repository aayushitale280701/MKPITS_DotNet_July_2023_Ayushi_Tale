using System;
namespace StaticField_DiffObjects
{
    class book
    {
        static string title;

        static book()
        {
            Console.WriteLine("Satic Constuctor Called");
            title = "MKPITS";
        }
        public void display()
        {
            Console.WriteLine("Title = " + title);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            book b1= new book();
            b1.display();//this will call static constructor only once
            book b2= new book();
            b2.display();// now static constructor will not be called;
            Console.ReadKey();
        }
    }
}