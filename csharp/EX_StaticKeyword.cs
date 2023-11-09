using System;
namespace Statickeywrods
{
    class Book
    {
        public static int bookid;
    }
    class program
    {
        static void Main(string[] args)
        {
            Book.bookid = 22;
            Console.WriteLine("Book id = " +Book.bookid);
        }
    }
}