using System;
namespace cube
{
    public class program
    {
        public static void Main(string[] args)
        {
            int num;
            int cube=0;
            int count = 1;
            Console.WriteLine("Enter the no.");
            num = Convert.ToInt32(Console.ReadLine());
            for ( count=1; count<=num; count++)
            {
                cube = count * count * count;
                Console.WriteLine("Cube {0} = {1}", count,cube);
            }
            
            Console.ReadLine();
        }
    }
}
