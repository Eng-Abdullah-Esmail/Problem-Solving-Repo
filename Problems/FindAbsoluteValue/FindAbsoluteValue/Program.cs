using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace FindAbsoluteValue
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

        static int FindAbs(int num)
        {
            return Math.Abs(num);
        }

       static void Print(int abs)
        {
            WriteLine("abs Value is:"+ abs);
        }
        static void Main(string[] args)
        {
            Print(FindAbs(ReadNumber("Enter a number")));

            ReadKey();
        }
    }
}
