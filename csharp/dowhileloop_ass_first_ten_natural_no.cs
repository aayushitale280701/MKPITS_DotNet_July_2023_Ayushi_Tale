using System;
namespace firsttenno
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            Console.WriteLine("Enter The first 10 natural numbers");
            do
            {
                Console.Write("{0} \n",num); 
                num++; 
            } while (num <= 10); 
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}