using System;
namespace multable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int count;
            int result;
            Console.WriteLine("Enter a num");
            num=Convert.ToInt32(Console.ReadLine());

            for(count=1; count<=10; count ++ )
            {
                result = num * count;
                Console.WriteLine(num + "X" + count + "=" + result);
                Console.ReadKey();
            }
        }
    }
}
