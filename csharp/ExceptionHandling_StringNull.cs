using System;
namespace ExceptionHandling
{
    class program
    {
        static void Main(string[] args)
        {
            string str = null;
            try
            {
                Console.WriteLine(str.Substring(5));
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}