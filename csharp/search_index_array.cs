using System;
namespace searcharrayindex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5 };
            int flag = 0;
            int index = 0;
            int number;
            Console.WriteLine("Enter number to be searched");
            number = Convert.ToInt32(Console.ReadLine()); //3
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] == number)
                {
                    flag = 1;
                    index = i + 1;
                    break;
                }
            }

            if (flag == 1)
            {
                Console.WriteLine("num {0} is found in an array", +index);
            }
            else
            {
                Console.WriteLine("number is not found in an array");
            }


            Console.ReadKey();
        }
    }
}
