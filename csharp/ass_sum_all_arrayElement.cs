using System;
namespace sumallelement
{
    class program
    {
        static void Main(string[] args)
        {

            int[] num = new int[3];
            int sum = 0;
            Console.WriteLine("Input element 3 in array:");
            for (int i = 0; i < 3; i++)
            {
                num[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\t");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Element -{0}-{1}", i, num[i]);
            }
            for (int i = 0;i < 3; i++)
            {
                sum = sum + num[i];
            }
            Console.WriteLine("Sum all element stored in array is:" +sum);
            Console.ReadKey();
        }
        
    }
}