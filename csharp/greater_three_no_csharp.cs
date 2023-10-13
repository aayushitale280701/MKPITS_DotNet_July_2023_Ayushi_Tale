using System;
namespace greaterthreeno
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter the Num1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Num2");
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Num3");
            num3=Convert.ToInt32(Console.ReadLine());

            if (num1 >num2 && num1 < num3)
            {
                Console.WriteLine("Number 1 is Greater");
            }
            else if (num2 > num3 )
            {
                Console.WriteLine("Number 2 is Greater");
            }
            else
            {
                Console.WriteLine("Number 3 is Greater");
            }
            Console.ReadKey();
        }
    }
}
