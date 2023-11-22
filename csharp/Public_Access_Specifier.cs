using System;
namespace publicaccess
{
    class PublicTest
    {
        public string name = "Ayushi Tale";
        public void  Msg(string msg)
        {
            Console.WriteLine("Hello"+msg);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PublicTest pt = new PublicTest();
            // accessing of variable
            Console.WriteLine("Hello "+pt.name);
            //accessing of function
            pt.Msg("Om Tale");
            Console.ReadKey();
        }
    }
}