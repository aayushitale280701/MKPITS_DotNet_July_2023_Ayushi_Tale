using System;
namespace tablennum
{
    public class program
    {
        public static void Main(string[] args)
        {
            int num;
            
            int counter = 1;
            int counter1 = 1;

            Console.WriteLine("Enter the no.");
            num = Convert.ToInt32(Console.ReadLine());

            for (counter=1; counter <= 10; counter++)
            {
                for (counter1=1; counter1 <= num; counter1++)
                {
                    
                    Console.Write("{0} * {1} = {2}",counter1,  counter,(counter1*counter));
                    Console.Write("\t");

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}