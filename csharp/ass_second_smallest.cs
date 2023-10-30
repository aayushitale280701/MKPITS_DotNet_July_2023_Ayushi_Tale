using System;
namespace smallestno
{
     class program
    {
        static void Main(string[] args)
        {
            int n ,n1;
            Console.WriteLine("Input the size of array element");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element -" + i + " ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
             n1 = arr.Length;
            Console.WriteLine("The second smallest element in array:" + n1);

            Console.ReadKey();
        }
    }
}