using System;
namespace Statickeywrods
{
    class Book
    {
        public static int bookid;
        public void display()
        {
            Console.WriteLine("Hello get display method");
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            Book.bookid = 22;
            Console.WriteLine("Book id = " + Book.bookid);
            b.display(); //to access static method display instance is not required
        }
    }
}