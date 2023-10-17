using System;
namespace switchgrade
{
    class program
    {
        static void Main(string[] args)
        {
            char grade;
            Console.WriteLine("Enter the Grade (E,V,G,A,F)");
            grade = Convert.ToChar(Console.ReadLine());

            switch (grade)
            {
                case 'E':
                    Console.WriteLine("Excellent");
                    break;
                case 'V':
                    Console.WriteLine("Very Good");
                    break;
                case 'G':
                    Console.WriteLine("Good") ;
                    break;
                case 'A':
                    Console.WriteLine("Avrage");
                    break;
                case 'F':
                    Console.WriteLine("Fail");
                    break;

                default:
                    Console.WriteLine("Invalid Grade Enter");
                    break;
                   
                    Console.ReadKey();
            }
        }
    }
}