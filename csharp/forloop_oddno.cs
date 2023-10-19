using System;
namespace oddno
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num;
            int cnt = 0;
            Console.WriteLine("Enter the no");
            num=Convert.ToInt32(Console.ReadLine());

            int sum = 1;
            while(true)
            {
                if (sum <= num) 
                {
                    if(cnt % 2 != 0)
                    {
                        Console.WriteLine("Odd no.{0}", cnt);
                        sum = sum + 1;
                    }
                }
                else
                {
                    break;
                }
                cnt++;
            }
            Console.ReadKey();
        }
    }
}