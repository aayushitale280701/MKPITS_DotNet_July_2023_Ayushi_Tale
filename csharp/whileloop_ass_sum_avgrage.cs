using System;
namespace sumandavreage
{
     class Program
     {
        public static void Main()
        {
            int i = 1, num, sum = 0;
            double avg;

            Console.Write("Read 10 numbers and calculate sum and average:\n");

            Console.Write("Enter the 10 numbers : \n");
            while (i <= 10)
            {
                Console.Write("Number-: {0} :", i);
                num = Convert.ToInt32(Console.ReadLine());
                sum += num;
                i++;
            }

            avg = sum / 10.0;

            Console.Write("The sum of 10 no is : {0}\nThe Average is : {1}\n", sum, avg);
        }
    }
}
