using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace CalculatePowerOfNumber
{
    internal class Program
    {
        static double ReadNumber(string msg)
        {
            double num = 0;
            WriteLine(msg);
            num = double.Parse(ReadLine());

            return (double)num;
        }

        static double RoundDecimalNumber(double num, int decimalPlaces)
        {
            double roundedNum = (double)Math.Round(num, decimalPlaces);
            return (double)roundedNum;
        }

        static void Print(double roundedDecimal)
        {
            WriteLine("The Rounded Decimal number is is :" + roundedDecimal);
        }

        static void Main(string[] args)
        {
            Print(RoundDecimalNumber(ReadNumber("Enter number"),(int)ReadNumber("Enter Decimal Point")));


            ReadKey();
        }
    }
}
