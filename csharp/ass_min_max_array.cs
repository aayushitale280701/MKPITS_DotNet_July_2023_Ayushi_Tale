using System;
namespace minmaxarray
{
    class program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            int max, min;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter element {0}", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            max = arr[0];
            for (int i = 0; i < 3; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            min = arr[0];
            for(int i = 0;i < 3; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Maximum={0}", max);
            Console.WriteLine("Minimun={0}", min);
        }
    }
}