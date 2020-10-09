using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Box Unit Tests by Student Name\n");

            int length, width, area, perimeter;

            Console.Write("Enter the length: ");
            length = int.Parse(Console.ReadLine());
            Console.Write("Enter the width: ");
            width = int.Parse(Console.ReadLine());

            Box myPaper = new Box(length, width);
            area = myPaper.calcArea();
            perimeter = myPaper.calcPerimeter();

            Console.WriteLine($"\nArea = {area}");
            Console.WriteLine($"Perimeter = {perimeter}");

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }
    }
}
