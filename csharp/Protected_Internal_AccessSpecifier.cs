using System;
namespace ProtectedInternal
{
    class ProTnternal
    {
        protected internal string name="Ayushi";
        protected internal void msg(string msg)
        {
            Console.WriteLine("Hello : "+msg);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            ProTnternal PI = new ProTnternal();
            PI.name = "OM : ";
            Console.WriteLine("HEllo: "+PI.name);
            Console.ReadKey();
        }
    }
}