using System;
namespace Marksinarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int total = 0;
            float per=1;
            string grade = null;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter 5 subject marks.");
                num[i] = Convert.ToInt32(Console.ReadLine());
                total = total + num[i];
                per = total / 500.0f * 100.0f;
            }           
            Console.WriteLine("Total of 5 subject marks = {0}", total);
            Console.WriteLine("Percentage of 5 subject marks = {0}", per);
            if (per >= 75)
                grade = "Distinction";
            else if (per >= 60 && per < 75)
                grade = "First Class";
            else
                grade = "Fail";
            Console.WriteLine("Grade: {0}", grade);
            Console.ReadKey();
        }
    }
}
