using System;
namespace arraymethodsort
{
    class program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            Array.Sort(arr);
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}