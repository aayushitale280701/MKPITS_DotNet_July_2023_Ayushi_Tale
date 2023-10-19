using System;
namespace tablennum
{
    public class program
    {
        public static void Main(string[] args)
        {
            int flag;
            Console.WriteLine("Enter the no.");
            flag = Convert.ToInt32(Console.ReadLine());
            int counter, cnt1;

            for (counter = 1; counter <= 10; counter++)
            {
                cnt1 = 1;
                for (cnt1 = 1; cnt1 <= flag; cnt1++)
                {

                    Console.Write("{0} * {1} = {2}", cnt1, counter, (cnt1 * counter));
                    Console.Write("\t");

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}