using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAreaCircumferenceOfCircle
{
    using System;

    class Program
    {
        static void Main()
        {
            double radius = ReadRadius();

            double area = CalculateCircleArea(radius);
            double circumference = CalculateCircleCircumference(radius);

            PrintArea(area);
            PrintCircumference(circumference);

            Console.ReadKey();
        }

        static double ReadRadius()
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());
            return radius;
        }

        static double CalculateCircleArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        static double CalculateCircleCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }

        static void PrintArea(double area)
        {
            Console.WriteLine("The area of the circle is: " + area);
        }

        static void PrintCircumference(double circumference)
        {
            Console.WriteLine("The circumference of the circle is: " + circumference);
        }
    }
}
