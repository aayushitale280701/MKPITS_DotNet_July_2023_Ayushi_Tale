using System;
namespace simplecalculation
{
    class Program
    {
           public static void Main(string[] args)
        {
            int num1, num2 ;
            char ch;
            Console.WriteLine("Enter num1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Here are option : ");
            Console.WriteLine("pres 1 for add");
            Console.WriteLine("Pres 2 for sub");
            Console.WriteLine("pres 3 for mul");
            Console.WriteLine("Pres 4 for div");
            Console.WriteLine("Pres 5 for exit");
            ch = Console.ReadLine()[0];
            
            if (ch=='1')
            {
                Console.WriteLine("Result" + (num1 + num2));
            }
            else if (ch=='2') 
            {
                Console.WriteLine("Result" +(num1-num2));
            }
            else if (ch == '3')
            {
                Console.WriteLine("Result" + (num1 * num2));
            }
            else if (ch == '4')
            {
                Console.WriteLine("Result" + (num1 / num2));
            }
            else if (ch == '5')
            {
                Console.WriteLine("Result = Exiting Program" );
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}