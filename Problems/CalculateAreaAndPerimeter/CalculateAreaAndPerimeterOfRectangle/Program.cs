using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreaAndPerimeterOfRectangle
{
   

    class Program
    {
        static void Main()
        {
            double length = ReadNumber("Enter the Width of The Rectangle: ");
            double width = ReadNumber("Enter the Length of The Rectangle: ");
            double area = CalculateArea(length, width);
            double perimeter = CalculatePerimeter(length, width);
            PrintArea(area);
            PrintPerimeter(perimeter);


            Console.ReadKey();
        }



        static double ReadNumber(string msg)
        {
            double size = 0.0;
            Console.Write(msg);
            size = double.Parse(Console.ReadLine());

            return (double)size;
        }

        static double CalculateArea(double length, double width)
        {
            return length * width;
        }

        static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        static void PrintArea(double area)
        {
            Console.WriteLine("The area of the rectangle is: " + area);
        }

        static void PrintPerimeter(double perimeter)
        {
            Console.WriteLine("The perimeter of the rectangle is: " + perimeter);
        }
    }
}
