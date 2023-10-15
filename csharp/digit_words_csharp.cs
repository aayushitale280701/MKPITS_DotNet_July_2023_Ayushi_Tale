using System;

public class Program
{
    public static void Main()
    {
        Console.Write("Enter a digit (0-9): ");
        int digit = Convert.ToInt32(Console.ReadLine());

        if (digit < 0 || digit > 9)
        {
            Console.WriteLine("Invalid digit. Please enter a number between 0 and 9.");
        }
        else
        {
            string[] digitNames = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            Console.WriteLine("The digit is {0}.", digitNames[digit]);
        }
    }
}
