using System;
namespace Floatdouble
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] floatArray = new float[4];
            double[] doubleArray = new double[4];
            for (int i=0;  i<4; i++)
            {
                floatArray[i] = i+0.2f;
                doubleArray[i] = i+0.2f;
            }
            Console.Write("FloatArray: ");
            for (int i=0; i<4; i++)
            {
                Console.Write("{0:F1}", floatArray[i]);
            }          
            
            Console.Write("doubleArray: ");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0:f1} ", doubleArray[i]);
            }
            
            Console.ReadKey();
        }
    }
}
    