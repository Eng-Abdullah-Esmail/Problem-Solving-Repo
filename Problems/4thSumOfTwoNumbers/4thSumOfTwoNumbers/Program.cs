using  static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace _4thSumOfTwoNumbers
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

        static int CalculateSumation(int num1, int  num2)
        {
            return num1 + num2;
        }

        static void PrintSumation(int sum)
        {
            WriteLine("the Sumation is " + sum);
        }

        static void Main(string[] args)
        {
            PrintSumation(CalculateSumation(ReadNumber("Enter First Number: "), ReadNumber("Enter Second Number: ")));

            ReadKey();
        }
    }
}
