using System;

namespace RandomNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int getRN(int min, int max)
        {
            Random rng = new Random();
            int answer = (int)rng.Next(min, max);
            return answer;
        }
    }
}
