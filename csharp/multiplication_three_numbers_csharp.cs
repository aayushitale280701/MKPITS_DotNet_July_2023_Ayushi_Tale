using System;
namespace fournoaverage
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1,num2,num3,num4,Total;
            Console.WriteLine("Enter the num1");
            num1=Convert.ToInt32(console.ReadLine());
            Console.WriteLine("Enter the num2");
            num2 = Convert.ToInt32(console.ReadLine());
            Console.WriteLine("Enter the num3");
            num3 = Convert.ToInt32(console.ReadLine());
            Console.WriteLine("Enter the num4");
            num4 = Convert.ToInt32(console.ReadLine());

            Total=(num1+num2+num3+num4)/(4) ;
            console.WriteLine("Total Average : " + total);
            Console.ReadLine();
        }
    }
}
