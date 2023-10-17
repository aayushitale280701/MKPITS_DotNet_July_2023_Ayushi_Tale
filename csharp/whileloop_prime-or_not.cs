using System;
namespace whileloopprimeornot
{
    class program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the no.");
            number=Convert.ToInt32(Console.ReadLine());
            int counter = 2;
            int flag = 0;
            while(counter < number)
            {
                if (number % counter == 0)
                {
                    flag = 1;
                    break;
                }
                counter++;
            }
            if (flag==0)
            {
                Console.WriteLine("no is prime");
            }
            else 
            {
                Console.WriteLine("no is not prime");
            }
            Console.ReadLine();
        }
    }
}