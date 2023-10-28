using System;
namespace sumrowcol
{
    class program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[3];
            int[] arr2 = new int[3];
           
            for (int count = 0; count < 3; count++)
            {
                Console.WriteLine("Enter element of arr1 :");
                arr1[count] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n\n*****Copy Process started ***** ");

            for (int count = 0; count < 3; count++)
            {
                arr2[count] = arr1[count];
            }
            Console.WriteLine("\n\nCopy Process Completed :");

            for (int count = 0; count < 3; count++)
            {
                Console.WriteLine("Element of arr2 :" + arr2[count]);
            }

            Console.ReadKey();
        }
    }
}