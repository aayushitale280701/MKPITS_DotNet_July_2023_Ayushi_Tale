using System;
namespace datatypeboolean
{
    class Program
    {
        public static void Main(string[] args)
        {
            Boolean b=true;
            Console.WriteLine("value "+b);
            Console.WriteLine("Enter value");
            b=Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("value =" + b);
            Console.ReadLine();
        }
    }
}
