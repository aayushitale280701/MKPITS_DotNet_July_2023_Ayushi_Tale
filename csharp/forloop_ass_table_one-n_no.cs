using System;
namespace primeno
{
    public class program
    {
        public static void Main(string[] args)
        {
            console.WriteLine("Prime no:");
            int num, counter, flag = 0;
            for(num=3; num<=20; num++)
            {
                flag = 0;
                counter = 2;
                for(counter=2; counter < num; counter++)
                {
                    if(num % 2 == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if(flag==0)
                {
                    Console.Write("Prime No:" + num);
                }
            }
            Console.ReadKey();
        }
    }
}