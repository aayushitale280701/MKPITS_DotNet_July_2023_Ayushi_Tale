using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subtwomatrix
{

    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] arr1 = new int[2, 2];
            int[,] arr2 = new int[2, 2];
            int[,] arr3 = new int[2, 2];

            Console.WriteLine("Input element in matrix 1:\n");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("Element -[{0},{1}]:", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("\n");
            Console.WriteLine("Input element in matrix 2: \n");

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine("Element -[{0},{1}]:", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Matrix 1 is : \n");
            for (i = 0; i < 2; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 2; j++)
                {
                    Console.Write("{0}\t", arr1[i, j]);
                }
            }
            Console.WriteLine("\n Matrix 2:");
            for (i = 0; i < 2; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 2; j++)
                {
                    Console.Write("{0}\t", arr1[i, j]);
                }
            }
            Console.Write("\n");
            Console.Write("Substraction of 2 matrix is :\n");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    arr3[i, j] = arr1[i, j] - arr2[i, j];
                }
            }

            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write(arr3[i, j] + "\t");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}