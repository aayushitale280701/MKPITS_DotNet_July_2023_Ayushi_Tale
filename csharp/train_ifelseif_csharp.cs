using System;
namespace train
{
    class Program
    {
        public static void Main(string[] args)
        {
            string origin;
            string destination;
            string Class;
            string passengername;
            int date;
            int trainno;
            int KM;
            int total;

            Console.WriteLine("Enter the Origin");
            origin = Console.ReadLine();
            Console.WriteLine("Enter the Destination");
            destination = Console.ReadLine();
            Console.WriteLine("Enter the Class");
            Class = Console.ReadLine();
            Console.WriteLine("Enter the Passengername");
            passengername = Console.ReadLine();
            Console.WriteLine("Enter the Date");
            date = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Trainno");
            trainno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the KM");
            KM = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Origin :{0} \nDestination :{1} \nPassengername :{2} \nDate :{3} \nTrainno :{4} \nKM :{5} ", origin, destination, passengername, date, trainno, KM);

            if (KM <= 100)
            {
                Console.WriteLine("Total Fare =100 ");
            }
            else if (KM >= 100 && KM <= 500)
            {
                Console.WriteLine("Total Fare =500");
            }
            else
            {
                Console.WriteLine("Total Fare =800");
            }

            Console.ReadKey();
        }    
    }
}
