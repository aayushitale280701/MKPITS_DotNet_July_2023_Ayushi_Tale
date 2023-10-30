using System;
namespace arraymethodcopy
{
    class program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int[] arr1 = new int[3];

            Array.Copy(arr, arr1, 3);
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.ReadKey();
        }
    }
}