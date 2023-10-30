using System;
namespace ascendingOrder
{
    class program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int temp;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enterr element : {0}- ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Discending Order");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0}", arr[i]);
            }
            Console.ReadKey();
        }
    }
}