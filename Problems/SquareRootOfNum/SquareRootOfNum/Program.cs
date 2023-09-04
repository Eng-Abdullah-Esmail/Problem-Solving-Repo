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
        static int ReadNumber(string msg)
        {
            int num = 0;
            WriteLine(msg);
            num = int.Parse(ReadLine());

            return num;
        }

        static double SquareRoot(int num)
        {
            
            return(double) Math.Sqrt(num);
        }

        static void Print(double square)
        {
            WriteLine("The square root is :" + square);
        }

        static void Main(string[] args)
        {
            Print(SquareRoot(ReadNumber("Enter number")));


            ReadKey();
        }
    }
}
