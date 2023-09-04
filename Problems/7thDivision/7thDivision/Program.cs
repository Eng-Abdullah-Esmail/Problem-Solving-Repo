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

        static int Divide(int num1, int num2)
        {
            if (num2 != 0)
                return num1 / num2;
            else
                return 0;
        }

        static void PrintDivision(int div)
        {
            if (div == 0)
                WriteLine("You can not divide by zero \n The division is " + div);
            else
                WriteLine("The Division is "+ div);
        }

        static void Main(string[] args)
        {
            PrintDivision(Divide(ReadNumber("Enter First Number: "), ReadNumber("Enter Second Number: ")));

            ReadKey();
        }
    }
}
