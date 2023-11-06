using System;
namespace staticMethodAndConstructor
{
    class Book
    {
        static string title;
        static Book()
        {
            Console.WriteLine("Static Constructor Called");
            title = "MKPITS";
        }
        public static void dispaly()
        {
            Console.WriteLine("Title = " +  title);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book.dispaly();
            Console.ReadKey();
        }
    }
}