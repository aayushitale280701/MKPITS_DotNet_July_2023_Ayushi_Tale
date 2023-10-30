using System;
namespace largestno
{
    class program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Input the size of array");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("element -" + i + " ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            int n1 = arr[arr.Length - 2];
            Console.WriteLine("The second largest in array:" + n1);
            Console.ReadKey();
        }
    }
}