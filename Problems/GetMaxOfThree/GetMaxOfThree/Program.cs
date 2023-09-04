using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetMaxOfThree
{
    

    public class Program
    {
        public static void Main()
        {
            int number1 = GetNumber("Enter the first number: ");
            int number2 = GetNumber("Enter the second number: ");
            int number3 = GetNumber("Enter the third number: ");

            int largestNumber = GetLargestNumber(number1, number2, number3);
            OutputLargestNumber(largestNumber);

            Console.ReadKey();
        }

        private static int GetNumber(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }

        private static int GetLargestNumber(int number1, int number2, int number3)
        {
            int largestNumber = number1;

            if (number2 > largestNumber)
            {
                largestNumber = number2;
            }

            if (number3 > largestNumber)
            {
                largestNumber = number3;
            }

            return largestNumber;
        }

        private static void OutputLargestNumber(int number)
        {
            Console.WriteLine("The largest number is: " + number);
        }
    }
}
