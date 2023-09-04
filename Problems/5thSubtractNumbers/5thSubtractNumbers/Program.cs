using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace _5thSubtractNumbers
{
    internal class Program
    {
        static int ReadNumber(string msg)
        {
            int num = 0;
            Write(msg);
            num = Convert.ToInt32(ReadLine());
            return num;

        }

        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        static void PrintSubtraction(int sub)
        {
            WriteLine("The Subtraction is " + sub);
        }

        static void Main(string[] args)
        {
            PrintSubtraction(Subtract(ReadNumber("Enter First Number: "), ReadNumber("Enter Second Number: ")));

            ReadKey();
        }
    }
}
