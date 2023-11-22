using System;
namespace internalAccessSpecifier
{
    public class InternalTest
    {
        internal string name = "Ayushi";
        internal void msg(string msg)
        {
            Console.WriteLine("Hello: "+msg);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            InternalTest test = new InternalTest();
            Console.WriteLine("Hello: "+test.name);
            test.msg("Om Tale");
            Console.ReadKey();
        }
    }
}