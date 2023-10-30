using System;
namespace arraymethodindexOf
{
    class program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int l = Array.IndexOf(arr, 2);
           Console.WriteLine("Index of 2 is :" +l);

            Console.ReadKey();
        }
    }
}