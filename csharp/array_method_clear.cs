using System;
namespace arraymethodclear
{
    class program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            Array.Clear(arr, 0, 2);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}