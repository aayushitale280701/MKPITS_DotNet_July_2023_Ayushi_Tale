using System;
namespace switchdesigntion
{
    class program
    {
        public static void Main(string[] args)
        {
            string designation;
            int bonus = 0;
            Console.WriteLine("Enter Dsignation Manager,Clerk or Peon");
            designation = Console.ReadLine();

            switch(designation)
            {
                case "Manager":
                    bonus = 10000;
                    break;
                case "Clerk":
                    bonus = 5000; ;
                    break;
                case "Peon":
                    bonus = 2000; ;
                    break;

                default:
                    Console.WriteLine("Invalid Designation");
                    break;
            }

            Console.WriteLine("bonus = {0}", bonus);
            Console.ReadKey();

        }

    }
    }
