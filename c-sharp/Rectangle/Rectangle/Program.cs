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
            double length, width, height;

            // get input
            Console.Write("Enter the length: ");
            length = double.Parse(Console.ReadLine());
            Console.Write("Enter the width: ");
            width = double.Parse(Console.ReadLine());
            Console.Write("Enter the height: ");
            height = double.Parse(Console.ReadLine());

            rectangle = new Box(length, width, height);

            // process/output
            Console.WriteLine($"Area = {rectangle.getArea()}");
            Console.WriteLine($"Perimeter = {rectangle.getPerimeter()}");
            Console.WriteLine($"Volume = {rectangle.getVolume()}");

            // pause
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
