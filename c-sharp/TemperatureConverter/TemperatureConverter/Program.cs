using System;

namespace TemperatureConverter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static double FToC(double f)
        {
            return (f - 32) * 5.0 / 9.0;
        }

        public static double CToF(double c)
        {
            return (c * 9.0 / 5.0) + 32;
        }
    }
}
