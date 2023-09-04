using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIFNumberDivisibleByAnother
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int number = GetNumber();
            int divisor = GetDivisor();

            if (IsDivisible(number, divisor))
            {
                OutputDivisible();
            }
            else
            {
                OutputNotDivisible();
            }

            Console.ReadKey();
        }

        private static int GetNumber()
        {
            Console.Write("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private static int GetDivisor()
        {
            Console.Write("Enter a divisor: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private static bool IsDivisible(int number, int divisor)
        {
            return number % divisor == 0;
        }

        private static void OutputDivisible()
        {
            Console.WriteLine("The number is divisible by the divisor.");
        }

        private static void OutputNotDivisible()
        {
            Console.WriteLine("The number is not divisible by the divisor.");
        }
    }
}
