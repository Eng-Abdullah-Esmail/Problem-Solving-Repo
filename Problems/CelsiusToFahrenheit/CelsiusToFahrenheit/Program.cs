using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheit
{
   

    class Program
    {
        static void Main()
        {
            double celsius = ReadCelsiusTemperature();

            double fahrenheit = ConvertCelsiusToFahrenheit(celsius);

            PrintFahrenheitTemperature(fahrenheit);

            Console.ReadKey();

        }

        static double ReadCelsiusTemperature()
        {
            Console.Write("Enter the temperature in Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            return celsius;
        }

        static double ConvertCelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;
            return fahrenheit;
        }

        static void PrintFahrenheitTemperature(double fahrenheit)
        {
            Console.WriteLine("The temperature in Fahrenheit is: " + fahrenheit);
        }
    }
}
