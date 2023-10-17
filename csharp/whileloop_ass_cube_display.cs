using System;
namespace cube
{

    class Program
    {
        public static void Main(string[] args) 
        {
            int i = 1, num, cube;
            Console.Write("Enter number of terms : ");
            num = Convert.ToInt32(Console.ReadLine());

            while (i <= num)
            {
                cube = i * i * i;
                Console.WriteLine("Number is : {0} and cube of the {1} is : {2}", i, i, cube);
                i++;
            }
        }
    }
}
