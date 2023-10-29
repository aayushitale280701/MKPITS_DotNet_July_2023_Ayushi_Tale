using System;
namespace sumrightdigonal
{
    public class program
    {
        public static void Main(string [] args)
        {
            int i, j, sum = 0;
            int[,] arr1 = new int[2,2];
            Console.Write("Enter Input elements matrix :\n");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write("Element - [{0}]{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (i == j) sum = sum + arr1[i, j];
                }
            }
            Console.Write("The matrix is :\n");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                    Console.Write("{0} ", arr1[i, j]);
                Console.Write("\n");
            }

            Console.Write("Addition of the right Diagonal elements is :{0}\n", sum);
        }
    }
}

