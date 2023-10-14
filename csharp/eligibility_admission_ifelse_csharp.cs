using System;
public class Exercise10
{
    public static void Main()
    {
        int p, c, m;
        Console.Write("Find eligibility for admission :");
        Console.Write("Eligibility Criteria :");
        Console.Write("Input the marks obtained in Physics :");
        p = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the marks obtained in Chemistry :");
        c = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the marks obtained in Mathematics :");
        m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Total marks of Maths, Physics and Chemistry : {0}\n", m + p + c);
        Console.Write("Total marks of Maths and  Physics : {0}\n", m + p);

        if (m >= 65)              
        Console.Write("The  candidate is eligible for admission.\n");
        else if (p >= 55)
        Console.Write("The candidate is not eligible.");
        else if (c >= 50)
        Console.Write("The candidate is not eligible.");
        else if ((m + p + c) >= 180 || (m + p) >= 140)
        Console.Write("The candidate is not eligible.");
        else
        Console.Write("The candidate is not eligible.");

        Console.ReadLine();
    }
}

