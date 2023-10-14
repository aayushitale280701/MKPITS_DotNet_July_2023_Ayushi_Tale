using System;
namespace xycoordinate
{
    class program
    {
        public static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter x");
            x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y");
            y=Convert.ToInt32(Console.ReadLine());

            if (x>0 && y>0)
            {
                Console.WriteLine("Point are {0} {1} first quadrant:", x, y);
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Point are {0} {1} second quadrant:", x, y);
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Point are {0} {1} third quadrant:", x, y);
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Point are {0} {1} fourt quadrant:",  x, y);
            }
            else
            {
                Console.WriteLine("Points are invalid");
            }

            Console.ReadKey();
        }
    }
}