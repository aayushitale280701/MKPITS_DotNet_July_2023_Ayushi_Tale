using System;
namespace PrivateAccess
{
    class Program
    {
        private string name = "Ayushi";
        private void Msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Hello" + p.name);
            p.Msg("Om Tale");
            Console.ReadLine();
        }
    }
}