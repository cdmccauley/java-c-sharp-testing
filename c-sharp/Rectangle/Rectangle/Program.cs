using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            // header
            Console.WriteLine("Box Unit Tests by Chris McCauley");

            // declarations
            Box rectangle;
            double length, width;

            // get input
            Console.Write("Enter the length: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Enter the width: ");
            width = double.Parse(Console.ReadLine());
            rectangle = new Box(length, width);

            // process/output
            Console.WriteLine($"Area = {rectangle.getArea()}");
            Console.WriteLine($"Perimeter = {rectangle.getPerimeter()}");

            // pause
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
