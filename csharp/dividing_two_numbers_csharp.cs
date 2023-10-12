using System;
namespace dividingtwonumbers
{
    class Program
    {
        static void Main(string[] args) 
        {
            int num1, num2 ;
            float div;
            Console.WriteLine("Enter Number 1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            num2=Convert.ToInt32(Console.ReadLine());
            div = (float)num1 / (float)num2;
            Console.WriteLine("Divide=" + div);
            Console.ReadKey();
        }
    }
}