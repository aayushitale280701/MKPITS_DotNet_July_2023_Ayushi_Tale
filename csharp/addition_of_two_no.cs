using System;
namespace additionprogram
{
    class program
    {
        static void Main()
        {
            int num1, num2, add;
            Console.WriteLine("Enter the num1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the num2");
            num2=Convert.ToInt32(Console.ReadLine());
            add=num1+num2;
            Console.WriteLine("Addition ="+add);
            Console.ReadKey();
        }
    }
}
