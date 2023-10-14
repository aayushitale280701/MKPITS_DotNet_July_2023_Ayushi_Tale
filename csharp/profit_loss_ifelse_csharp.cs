using System;
namespace vawel
{
    class Program
    {
        public static void Main(string[] args)
        {
            int s_p, c_p, profit;
            Console.WriteLine("Enter selling price");
            s_p=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter cost price");
            c_p=Convert.ToInt32(Console.ReadLine());
            profit = s_p - c_p;

            if (s_p > c_p)
                Console.WriteLine("You got profit :"+ profit);
            else
                Console.WriteLine("You got loss :"+ profit);
            Console.ReadLine();
        }
    }
}