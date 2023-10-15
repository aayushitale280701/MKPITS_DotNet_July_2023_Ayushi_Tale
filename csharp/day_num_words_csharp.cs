using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter a day number : ");
        int dayNumber = Convert.ToInt32(Console.ReadLine());

        if (dayNumber < 1 || dayNumber > 7)
        {
            Console.WriteLine("Invalid day number. Please enter a number between 1 and 7.");
        }
        else if (dayNumber == 1)
        {
            Console.WriteLine("The day is Monday.");
        }
        else if (dayNumber == 2)
        {
            Console.WriteLine("The day is Tuesday.");
        }
        else if (dayNumber == 3)
        {
            Console.WriteLine("The day is Wednesday.");
        }
        else if (dayNumber == 4)
        {
            Console.WriteLine("The day is Thursday.");
        }
        else if (dayNumber == 5)
        {
            Console.WriteLine("The day is Friday.");
        }
        else if (dayNumber == 6)
        {
            Console.WriteLine("The day is Saturday.");
        }
        else if (dayNumber == 7)
        {
            Console.WriteLine("The day is Sunday.");
        }
        else
        {
            Console.WriteLine("Invalid no.");
        }
        Console.ReadLine();
    }
}
