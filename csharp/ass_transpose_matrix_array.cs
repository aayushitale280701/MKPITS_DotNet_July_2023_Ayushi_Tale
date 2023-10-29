using System;
namespace transposemarix
{
    class program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] arr1 = new int[2, 2];
            Console.WriteLine("Enter element input");
            for (i = 0; i < 2; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.Write("Element{0}-{1}:", i,j);
                    arr1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("\n Matrix is :\n");
            for (i = 0;i < 2; i++)
            {
                Console.WriteLine("\n");
                for (j = 0;j < 2; j++)
                {
                    Console.WriteLine("{0}\t ", arr1[i,j]);
                    Console.WriteLine("\t");
                    Console.WriteLine("Transpose of matrix");
                }
            }
            for (i = 0; i<3; i++)
            {
                for (j = 0; j<3; j++)
                {
                    Console.Write(arr1[j,i]+"\t");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}