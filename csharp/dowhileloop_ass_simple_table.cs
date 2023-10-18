using System;
namespace simpletable
{
    public class program
    {
        public static void Main(string[] args)
        {
            int i = 1, num;

            Console.Write("Enter an integer: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The multiplication table of {0} is", num);

            do
            {
                Console.WriteLine("{0} x {1} = {2}", num, i, num * i);
                i++;
            } while (i <= 10);
            Console.Read();
        }
    }
}
