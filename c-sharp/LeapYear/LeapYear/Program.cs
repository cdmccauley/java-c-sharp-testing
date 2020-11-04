using System;

namespace LeapYear
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int numFebDays(int year)
        {
            int days;

            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                    days = 29;
                else
                    days = 28;
            }
            else if (year % 4 == 0)
                days = 29;
            else
                days = 28;

            return days;
        }

        public static bool isLeapYear(int year)
        {
            bool theAnswer;

            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                    theAnswer = true;
                else
                    theAnswer = false;
            }
            else if (year % 4 == 0)
                theAnswer = true;
            else
                theAnswer = false;

            return theAnswer;
        }
    }
}
