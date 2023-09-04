using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTotalAndAvergeOfArray
{
    using System;

    public class Program
    {
        public static void Main()
        {
            double[] numbers = new double[4];

            InputNumbers(numbers);
            double total = CalculateTotal(numbers);
            double average = CalculateAverage(numbers);

            OutputResult(total, average);

            Console.ReadKey();
        }

        private static void InputNumbers(double[] numbers)
        {
            Console.WriteLine("Enter four numbers:");

            for (int i = 0; i < 4; i++)
            {
                Console.Write($"Number {i + 1}: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        private static double CalculateTotal(double[] numbers)
        {
            double total = 0;

            foreach (double number in numbers)
            {
                total += number;
            }

            return total;
        }

        private static double CalculateAverage(double[] numbers)
        {
            double total = CalculateTotal(numbers);
            double average = total / numbers.Length;
            return average;
        }

        private static void OutputResult(double total, double average)
        {
            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"Average: {average}");
        }
    }
}
