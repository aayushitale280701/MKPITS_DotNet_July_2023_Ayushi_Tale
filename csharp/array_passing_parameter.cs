using System;
namespace arraymethodpassingparameter
{
    class program
    {
        static void acceptarray(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum of array elements are :" + sum);
        }
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3 };
            acceptarray(num);

            int[] num1 = { 11, 22, 33 };
            acceptarray(num1);

            Console.ReadKey();
        }
    }
}
