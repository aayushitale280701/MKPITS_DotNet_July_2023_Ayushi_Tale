using System;
namespace duplicateElement
{
    class program
    {
        static void Main(string[] args)
        {
            
            int cnt = 0;
            int[] a1 = new int[5];
            
            Console.WriteLine("Element of 3 array :");

            for (int i = 0; i<5; i++)
            {
                a1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n");

            for (int i = 0; i < 5; i++)
            { 
                
                    Console.WriteLine("Element of array-{0}={1} ",i, a1[i]);
              
            }
            Console.WriteLine("\n");
            for(int i = 0;i < 5; i++)
            {
                for(int j = i+1; j < 5; j++)
                {
                    if (a1[i] == a1[j])
                    {
                        cnt++;
                        break;
                    }
                }
            }
            Console.WriteLine("Total elelent of duplicate:"+cnt);
            Console.ReadKey();
        }
    }
}