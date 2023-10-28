using System;
namespace threebythreematrix
{
    class program
    {
        static void Main(string[] args)
        {
            int row, col;
            int[,] arr =new int  [ 3 , 3 ];
            Console.WriteLine("Enter the Number");
            for (row=0; row<3; row++)
            {
                for (col=0; col<3; col++)
                {
                    Console.WriteLine("Element - {0}:{1}: ",row ,col);
                    arr[row,col]=Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix is:");
            Console.WriteLine("\t");
            for (row=0; row<3; row++)
            {
                for (col = 0; col < 3; col++)
                {
                    Console.Write(arr[row, col] + "\t");
                }
                Console.WriteLine();
            }
           
            Console.ReadKey();
            
        }
    }
}