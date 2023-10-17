using System;
namespace switchmothnamenoday
{

    public class Program
    {
        public static void Main()
        {
            int monno;
            Console.Write("Enter Month No : ");
            monno = Convert.ToInt32(Console.ReadLine());

            switch (monno)
            {
                case 1:            
                case 3:
                case 5:
                case 7:
                case 8:
                case 12:
                case 10:
                    Console.Write("Month have 31 days");
                    break;
                case 4:
                case 6:        
                case 9:
                case 11:
                    Console.Write("Month have 30 days");
                    break;
                case 2:
                    Console.Write("Month have 28-29 days");
                    break;


                default:
                    Console.Write("Invalid Month number. \nPlease try again ....\n");
                    break;
                    Console.ReadLine();
            }
        }
    }
}
