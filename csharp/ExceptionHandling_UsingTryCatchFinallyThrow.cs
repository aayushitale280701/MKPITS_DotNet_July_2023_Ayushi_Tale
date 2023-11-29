using System;
namespace UsingTryCatchFinallyThrow
{
    class program
    {
        static void Main (string[] ags)
        {
            int age = 0;
            try
            {
                Console.WriteLine("Enter Age  ");
                age = Convert.ToInt32(Console.ReadLine());
                //if the user enter age below 18 then throw the exception
                if(age < 18)
                {
                    throw new Exception("Age should be greater or equal to 18  ");
                }
            }
            catch(Exception ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("Enter age 18 or greater than 18  ");
                age = Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine("Finally block is executing  ");
                Console.WriteLine("Age 18 "+age);
            }
            Console.WriteLine("Byee  ");
            Console.ReadKey();  
        }
    }
}