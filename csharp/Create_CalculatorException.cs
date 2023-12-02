using System;
using System.Collections;
using System.Collections.Generic;
namespace CalculatorException
{
    class Claculator
    {
        public int num1,num2;
        public int result;
        public void add(int num1, int num2)
        {
            result = num1 + num2;
        }
        public void sub(int num1, int num2)
        {
            result = num1 - num2;
        }
        public void mul(int num1, int num2)
        {
            result = num1 * num2;
        }
        public void div(int num1, int num2)
        {
            if (num1 != 0 && num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Cant not be devided by zero...");
            }
        }
        public void display()
        {
            Console.WriteLine("Result: "+result);
        }

        class program
        {
            static void Main(string[]args)
            {
                Claculator c = new Claculator();
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter no 1: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter no 2: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Choice (+, -, *, / ) : " );
                        string choice = Console.ReadLine();

                        if (choice == "+")
                        {
                            c.add(num1, num2);
                        }
                        else if (choice == "-")
                        {
                            c.sub(num1, num2);
                        }
                        else if (choice == "*")
                        {
                            c.mul(num1, num2);
                        }
                        else if (choice == "/")
                        {
                            c.div(num1, num2);
                        }
                        c.display();
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
                Console.ReadKey();
            }
        }
    }
}