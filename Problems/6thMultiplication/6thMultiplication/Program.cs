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

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        static void PrintProduct(int product)
        {
            WriteLine("The Multiplication is " + product);
        }

        static void Main(string[] args)
        {
            PrintProduct(Multiply(ReadNumber("Enter First Number: "), ReadNumber("Enter Second Number: ")));

            ReadKey();
        }
    }
}
