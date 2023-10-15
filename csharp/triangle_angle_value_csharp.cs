using System;
namespace triangleanglevalue
{
    class Program
    {
        public static void Main()
        {
            int anga, angb, angc, sum;
            Console.Write("Check whether a triangle can be formed by given value:\n");
            Console.Write("Enter angle1 of triangle: ");
            anga = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter angle 2 of triangle: ");
            angb = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter angle 3 of triangle: ");
            angc = Convert.ToInt32(Console.ReadLine());

            sum = anga + angb + angc;

            if (sum == 180)
            {
                Console.Write("The triangle is valid.\n");
            }
            else
            {
                Console.Write("The triangle is not valid.\n");
            }
        }

    }
}
