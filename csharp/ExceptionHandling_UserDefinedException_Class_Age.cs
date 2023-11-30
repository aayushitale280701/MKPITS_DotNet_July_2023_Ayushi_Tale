using System;
namespace userDefinedException
{
    class Age
    {
        public int age = 0; //age=20;
        public void showage()
        {
            if (age <= 18)
            {
                throw (new AgeIsException("Age should be greater than 18  "));
            }
            else
            {
                Console.WriteLine("Age : {0} ",age);
            }
        }
    }
    public class AgeIsException : ApplicationException
    {
        public AgeIsException(string message) : base(message)
        {

        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Age a = new Age();
            try
            {
                a.showage();
            }
            catch(AgeIsException ee)
            {
                Console.WriteLine("AgeIsException: {0} ",ee.Message);
            }
            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}