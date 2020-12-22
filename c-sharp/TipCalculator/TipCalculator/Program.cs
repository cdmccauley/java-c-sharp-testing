using System;

namespace TipCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static double calcTip(double cost, double tipPct)
        {
            return Math.Round(cost * (tipPct / 100), 2);
        }

        public static double calcTotal(double cost, double tipAmt)
        {
            return Math.Round(cost + tipAmt, 2);
        }
    }
}
