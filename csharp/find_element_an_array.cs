using System;
namespace elementanarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5 };
            int flag = 0;
            int usernum;
            Console.WriteLine("Enter number to be searched");
            usernum = Convert.ToInt32(Console.ReadLine()); 
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == usernum)
                {
                    flag = 1;
                    break;
                }
            }

            if (flag == 1)
            {
                Console.WriteLine("Number {0} is found in an array", usernum);
            }
            else
            {
                Console.WriteLine("Number is not found in an array");
            }
            Console.ReadKey();
        }
    }
}

