using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAreaByHeronsFormula
{
   

    class Program
    {
        static void Main()
        {
            double sideA = ReadSide("A");
            double sideB = ReadSide("B");
            double sideC = ReadSide("C");

            double area = CalculateTriangleArea(sideA, sideB, sideC);

            PrintArea(area);


            Console.ReadKey();

        }

        static double ReadSide(string sideName)
        {
            Console.Write("Enter the length of side " + sideName + ": ");
            double side = double.Parse(Console.ReadLine());
            return side;
        }

        static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            double semiPerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
            return area;
        }

        static void PrintArea(double area)
        {
            Console.WriteLine("The area of the triangle is: " + area);
        }
    }
}
