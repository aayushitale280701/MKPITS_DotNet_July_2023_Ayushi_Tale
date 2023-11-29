using System;
namespace another_ex_throw
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            try
            {
                Console.WriteLine("Enter age  ");
                age = Convert.ToInt32(Console.ReadLine());
                //if the user enter age below 18 than throw the exception

                if(age<18)
                {
                    throw new Exception("Age should be greater or equal to 18  ");
                }
            }
            catch (OverflowException ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("Enter a small number please  ");
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("Enter a small number please  ");
                age=Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine("Finally block is executing  ");
                Console.WriteLine("Age= "+age);
            }
            Console.WriteLine("Byee");
            Console.ReadKey();
        }
    }
}