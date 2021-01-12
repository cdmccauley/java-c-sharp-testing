using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int left;
            int right;
            int result;
            Operations ops = new Operations();

            Console.Write("Enter left: ");
            left = int.Parse(Console.ReadLine());
            Console.Write("Enter right: ");
            right = int.Parse(Console.ReadLine());

            result = ops.Division(left, right);

            Console.WriteLine(result.ToString());

            Console.ReadKey();
        }
    }
}
