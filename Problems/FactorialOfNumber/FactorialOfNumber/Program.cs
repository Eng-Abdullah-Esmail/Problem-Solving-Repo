using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace SumFrom1ToN
{
    internal class Program
    {
        static int ReadNumber()
        {
            int num;
            WriteLine("Enter a number to find Factorial");
            num = Convert.ToInt32(ReadLine());

            return num;
        }

        static int FindFactorial(  int number)
        {
            int factor = 1;
            for (int i = 1; i <= number; i++)
            {
                factor =factor* i;
            }


            return factor;
        }


        static void PrintFactorial(int factorial)
        {
            WriteLine("Factorial is:" + factorial);
        }

        static void Main(string[] args)
        {
            PrintFactorial(FindFactorial(  ReadNumber()));

            ReadKey();
        }
    }
}
