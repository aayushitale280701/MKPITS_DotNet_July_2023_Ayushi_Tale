using System;
namespace simpletable
{
    public class program
    {
        public static void Main(string[] args)
        {
            int num;
            int result = 0;
            int counter = 1;

            Console.WriteLine("Enter the no.");
            num=Convert.ToInt32(Console.ReadLine());

            for (int counte; counter<=10; counter++)
            {
                result = num * counter;
                Console.WriteLine("{0} * {1} = {2}", num, counter, result);
            }
            
            Console.ReadLine();
        }
    }
}