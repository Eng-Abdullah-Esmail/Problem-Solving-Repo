using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateVolumeOfCube
{

    class Program
    {
        static void Main()
        {
            double sideLength = ReadSideLength();

            double volume = CalculateCubeVolume(sideLength);

            PrintVolume(volume);

            Console.ReadKey();
        }

        static double ReadSideLength()
        {
            Console.Write("Enter the side length of the cube: ");
            double sideLength = double.Parse(Console.ReadLine());
            return sideLength;
        }

        static double CalculateCubeVolume(double sideLength)
        {
            double volume = Math.Pow(sideLength, 3);
            return volume;
        }

        static void PrintVolume(double volume)
        {
            Console.WriteLine("The volume of the cube is: " + volume);
        }
    }
}
