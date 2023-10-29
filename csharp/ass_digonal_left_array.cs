using System;
namespace sumleftdigonal
{
    public class program
    {
        public static void Main(string[] args)
        {
            int i, j, sum = 0, n, m = 0;
            int[,] arr1 = new int[2,2];
            Console.Write("Input the size of the square matrix : ");
            n = Convert.ToInt32(Console.ReadLine());
            m = n;
            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Element - [ {0},{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("The matrix is :\n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(" {0} ", arr1[i, j]);
                }
                Console.Write("\n");
            }
            for (i = 0; i < n; i++)
            {
                m = m - 1;
                for (j = 0; j < n; j++)
                {
                    if (j == m)
                    {
                        sum = sum + arr1[i, j];
                    }
                }
            }
            Console.Write("Addition of the left Diagonal elements is : {0}\n", sum);
            Console.ReadKey();
        }
    }
}