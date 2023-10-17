using System;
namespace tablennumber
{
    class Program
    {
        public static void Main()
        {
            int j = 1, i = 1, num;
            Console.Write("Enter the table number starting from 1 to n  : ");
            num = Convert.ToInt32(Console.ReadLine());

            while (i <= num)
            {
                j = 1;
                while (j <= 10)
                {
                    if (j == 1)
                    {
                        Console.Write("{0} X {1} = {2}\n", i, j, i * j);
                    }
                    else
                    {
                        Console.Write("         {0} X {1} = {2}\n", i, j, i * j);
                    }
                    j++;
                }
                i++;
            }
        }
    }
}
