using System;
namespace sumoffiveno
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num;
            int sum = 0;
            float per=0;
            string grade = null;
            for (int cnt = 1; cnt <= 5; cnt++)
            {
                Console.WriteLine("Enter subject marks ");
                num = Convert.ToInt32(Console.ReadLine());
                sum = sum + num;
                per =( sum / 500.0f )* 100.0f;

            }
            Console.WriteLine("Sum of five subject:- " + sum);
            Console.WriteLine("Percentage:- " + per);

            if(per>=75)
            {
                grade = "Distinction";
            }
            else if(per>=60 && per<75)
            {
                grade = "First Class";
            }
            else
            {
               grade= "Fail";
            }
            Console.WriteLine("Grade:- {0}", grade);
            Console.ReadLine();
        }
    }
}
