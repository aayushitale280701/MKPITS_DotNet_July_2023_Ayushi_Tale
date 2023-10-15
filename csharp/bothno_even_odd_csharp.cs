using System;
namespace eveoddboth
{

    class program
    {
        public static void Main()
        {
            int n1, n2;
            bool bothEven;
            Console.Write("Enter First number: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second number: ");
            n2 = Convert.ToInt32(Console.ReadLine());



            bothEven = ((n1 % 2 == 0)
                && (n2 % 2 == 0)) ? true : false;

            Console.WriteLine(bothEven ?
              "there're numbers bothEven" :
              "there's a number odd");
        }
    }
}
