using System;
namespace reverseorder
{
    class program
    {
        static void Main(string[] args)
        {
            int[] num=new int[3];
            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Number");
                num[i]= Convert.ToInt32(Console.ReadLine());
            }
            
            Console.WriteLine("\nThe value store into the array in reverse are: ");
            for (int i = 2; i>=0; i--)
            {
                Console.Write("{0}", num[i]);
            }
            Console.ReadKey();
        }
    }
}