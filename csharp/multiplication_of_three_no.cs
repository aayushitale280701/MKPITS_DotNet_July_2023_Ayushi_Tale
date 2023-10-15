using System;
namespace multiplicationofthreeno
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1, num2, num3, mul;
            Console.WriteLine("Enter the num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the num3");
            num3 = Convert.ToInt32(Console.ReadLine());
            mul=num1*num2*num3;
            Console.WriteLine("Multiplication :" + mul);
            Console.ReadKey();
        }
    }
}
