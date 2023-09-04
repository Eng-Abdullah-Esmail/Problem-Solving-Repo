using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateVolumeOfSphere
{
    

    class Program
    {
        static void Main()
        {
            double radius = ReadRadius();

            double volume = CalculateSphereVolume(radius);

            PrintVolume(volume);


            Console.ReadKey();
        }

        static double ReadRadius()
        {
            Console.Write("Enter the radius of the sphere: ");
            double radius = double.Parse(Console.ReadLine());
            return radius;
        }

        static double CalculateSphereVolume(double radius)
        {
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
            return volume;
        }

        static void PrintVolume(double volume)
        {
            Console.WriteLine("The volume of the sphere is: " + volume);
        }
    }
}
