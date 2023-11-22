using System;
namespace AccessingProtected
{
    class ProtectedTest
    {
        protected string name = "Ayushi";
        protected void msg(string msg)
        {
            name = "Ayushi";
            Console.WriteLine("Hello  "+msg);
        }
    }
    class Program :ProtectedTest
    {
        static void Main(string[] args)
        {
            Program p = new Program();
           
            // Accessing protected variable  
            Console.WriteLine("Hello " + p.name);
            // Accessing protected function  
            p.msg("Om Tale");

        }
    }
}