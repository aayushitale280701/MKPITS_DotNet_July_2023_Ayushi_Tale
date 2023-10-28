using System;
namespace storeelementarray
{
    class program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
           for (int i=0; i<num.Length; i++)
            {
                Console.WriteLine("Enter 10 Number");
                num[i]=Convert.ToInt32(Console.ReadLine());
            }
           for (int i=0; i<num.Length; i++)
            {
                Console.WriteLine("Element - {0} ={1}", i, num[i]);
            }
           Console.WriteLine("\t");
            Console.WriteLine("Element in Array");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(" {0}, ", num[i]);
            }
            Console.ReadKey();
        }
    }
}