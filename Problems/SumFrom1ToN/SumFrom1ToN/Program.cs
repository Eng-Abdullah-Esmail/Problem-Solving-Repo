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
            int num = 0;
            WriteLine("Enter a number to find the Sum from 1 to N");
            num = Convert.ToInt32(ReadLine());

            return num;
        }

        static int FindSum(int number)
        {
            int sum = 0;
            for(int i =1; i <= number; i++)
            {
                sum += i;
            }
            return sum;
        }


        static void PrintSumToN(int sum)
        {
            WriteLine("Sum from one to N is:" + sum);
        }

        static void Main(string[] args)
        {
            PrintSumToN(FindSum(ReadNumber()));

            ReadKey();
        }
    }
}
