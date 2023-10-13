using System;
namespace largerlessthan
{
    class Program
    {
        public static void Main(string[] args)
        {
            int m,n;
            Console.WriteLine("Enter the number");
            m=Convert.ToInt32(Console.ReadLine());         

            if (m>0)
            {
                n = 1;
                Console.WriteLine("the value n={0}", n);
            }
            else if (m==0) 
            {
                n = 0;
                Console.WriteLine("the value m={0}",n);
            }
            else
            {
                n = -1;
                Console.WriteLine("the value n={0}",n);
            }
            Console.ReadKey();            
        }
    }
}
