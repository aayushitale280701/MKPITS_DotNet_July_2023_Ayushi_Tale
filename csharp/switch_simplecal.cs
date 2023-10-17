using System;
namespace switchsimplecla
{
    class program
    {
        public static void Main(string[] args)
        {
            int num1, num2, total,op;
            
            Console.WriteLine("Enter no one");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no two");
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition,\nMultipication,\nSubtraction,\nDivision");
            Console.WriteLine("Enter choice");
            op= Convert.ToInt32(Console.ReadLine());
            

            switch(op)
            {
                case 1:
                    total = num1 + num2;
                    Console.WriteLine("Addition = {0}", total);
                    
                    break;
                case 2:
                    total = num1 - num2;
                    Console.WriteLine("Subtraction = {0}", total);

                    break;
                case 3:
                    total = num1 * num2;
                    Console.WriteLine("Multiplication = {0}", total);
                    break;
                case 4:
                    total = num1 / num2;
                    Console.WriteLine("Division = {0}", total);
                    break;

                default:
                    Console.WriteLine("Invalid opration perform");
                    break;
                    Console.ReadLine();
            }
        }

    }
}
