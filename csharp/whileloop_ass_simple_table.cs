using System;
namespace simpletable
{
    public class program
    {
        public static void Main()
        {
            int i = 1, num, mul;
            Console.Write("Enter the number (Table-calculated) : ");
            num = Convert.ToInt32(Console.ReadLine());

            while (i <= 10)
            {
                mul = num * i;
                Console.WriteLine("{0} X {1} = {2}", num, i, mul);
                i++;
            }
            Console.ReadLine();
        }
    }
}
