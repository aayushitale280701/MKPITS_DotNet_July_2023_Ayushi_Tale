using System;
namespace MoreMethodClass
{
    class Book
    {
        public static int bookid;
        public static void display()
        {
            Console.WriteLine("Hello from static dispaly method");
        }
    }
    class Program
    {
        static void Main (string[] args)
        {
            Book.bookid = 11;
            Program P = new Program(); 
            P.Main();
            Console.WriteLine("Book id" + Book.bookid);
        }
        void Main()
        {
            Console.WriteLine("Hello from another main method");
        }
    }
}