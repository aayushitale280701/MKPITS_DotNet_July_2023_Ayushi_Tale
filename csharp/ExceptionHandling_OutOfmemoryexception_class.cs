using System;
using System.Text;

namespace Outofmemoryexception
{
    class program
    {
        static void Main(string[] args)
        {
            string name ="Ayushi";
            string subject = "Tale om rajesh ";
            Console.WriteLine("Length of name "+name.Length);
            StringBuilder sb = new StringBuilder(name.Length,name.Length);
            try
            {
                sb.Append(subject);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("Bye ");
            Console.ReadKey();
        }
    }
}