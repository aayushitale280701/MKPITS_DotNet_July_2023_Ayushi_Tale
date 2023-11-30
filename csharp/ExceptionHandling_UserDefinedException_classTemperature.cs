using System;
using System.Security.Cryptography.X509Certificates;

namespace ClassTemperature
{
    class Temperature
    {
        int temperature = 0;
        public void showTemp()
        {
            if (temperature == 0)
            {
                throw (new TempIsZeroException ("Zero Temperature found "));
            }
            else
            {
                Console.WriteLine("Temperature : {0} ", temperature);
            }
        }
    }
    public class TempIsZeroException : ApplicationException
    {
        public TempIsZeroException(string message):base(message)
        {

        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            try
            {
                temp.showTemp();
            }
            catch(TempIsZeroException ee)
            {
                Console.WriteLine("TempIsZeroException: {0} ",ee.Message);
            }
        }
    }
}