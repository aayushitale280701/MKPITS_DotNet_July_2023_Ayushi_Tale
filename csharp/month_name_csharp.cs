using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter a month number (1-12): ");
        int monthNumber = Convert.ToInt32(Console.ReadLine());

        if (monthNumber < 1 || monthNumber > 12)
        {
            Console.WriteLine("Invalid month number. Please enter a number between 1 and 12.");
        }
        else
        {
            string[] monthNames = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            Console.WriteLine("The month is {0}.", monthNames[monthNumber - 1]);
        }
    }
}
