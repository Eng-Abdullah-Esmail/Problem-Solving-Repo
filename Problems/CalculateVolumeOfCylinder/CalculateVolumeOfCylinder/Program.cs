using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateVolumeOfCylinder
{
   

    class Program
    {
        static void Main()
        {
            double radius = ReadRadius();
            double height = ReadHeight();

            double volume = CalculateCylinderVolume(radius, height);

            PrintVolume(volume);

            Console.ReadKey();

        }

        static double ReadRadius()
        {
            Console.Write("Enter the radius of the cylinder: ");
            double radius = double.Parse(Console.ReadLine());
            return radius;
        }

        static double ReadHeight()
        {
            Console.Write("Enter the height of the cylinder: ");
            double height = double.Parse(Console.ReadLine());
            return height;
        }

        static double CalculateCylinderVolume(double radius, double height)
        {
            double volume = Math.PI * Math.Pow(radius, 2) * height;
            return volume;
        }

        static void PrintVolume(double volume)
        {
            Console.WriteLine("The volume of the cylinder is: " + volume);
        }
    }
}
