using System;
namespace arraymethodgetLength
{
    class program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6};
            int l=arr.GetLength(0);
            Console.WriteLine(l);

            Console.ReadKey();
        }
    }
}