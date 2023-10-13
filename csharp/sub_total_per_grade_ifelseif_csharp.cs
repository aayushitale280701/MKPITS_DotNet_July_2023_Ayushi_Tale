using System;
namespace subtotalpergrade
{
    class Program
    {
        public static void Main(string[] args)
        {
            int sub1, sub2, sub3, total;
            float per;
            string grade ;

            Console.WriteLine("Enter subject 3 marks");
            sub1=Convert.ToInt32(Console.ReadLine());
            sub2=Convert.ToInt32(Console.ReadLine());
            sub3=Convert.ToInt32(Console.ReadLine());
            total=sub1 + sub2 + sub3;
            Console.WriteLine("Total :  " +total);
            per = (total / 300.0f) * 100.0f;
            Console.WriteLine("Percentage : {0}", per);
            
            if (per > 75)
            {
                grade = "Distinction";
            }
            else if (per >60 &&  per < 75)
            {
                grade = "Frist Class";
            }
            else
            {
                grade = "Fail";
            }
            Console.WriteLine("Grade : {0} ", grade);
            Console.ReadKey();
        }
    }
}