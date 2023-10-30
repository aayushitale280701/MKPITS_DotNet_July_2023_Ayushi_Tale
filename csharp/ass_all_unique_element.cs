using System;
namespace alluniqueelement
{
    class program
    {
        static void Main(string[] args)
        {
            int[] num=new int[3];
            int cnt =0;

            for (int i = 0; i<3; i++)
            {
                Console.WriteLine("Enter element {0}- ");
                num[i]=Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0;i<3; i++)
            {
                cnt = 0;
                for (int j = 0; j<3; j++)
                {
                    if (i!=j)
                    {
                        if (num[i] == num[j])
                        {
                            cnt++;
                            break;
                        }
                    }
                }
                if (cnt == 0)
                {
                    Console.WriteLine("Unique element : {0}", num[i]);
                }
            }
            Console.ReadKey();
        }
    }
}