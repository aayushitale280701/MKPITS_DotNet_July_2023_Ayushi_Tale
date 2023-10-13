using System;
namespace largestthreeno
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the Number1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number3");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("The number is largest. {0}", num1);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("The number is largest. {0}", num2);
            }
            else
            {
                Console.WriteLine("The number is largest. {0}", num3);
            }
            Console.ReadLine();
        }
    }
}
