using System;
namespace interfaceDeclaration
{
    interface ILogger
    {
        string LogMessage(string message);
        string LogError(string errorMessage);
        

    }
    class ConsoleLogger : ILogger
    {
       
    
        public string LogMessage(string message)
        {
            return "Message";
        }
    
   
        public string LogError(string errorMessage)
        {
            return "Error Message";
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            ILogger l;
            l = new ConsoleLogger();
            string res = l.LogMessage("Hii");
            Console.WriteLine(res);
            res = l.LogError("Error");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}