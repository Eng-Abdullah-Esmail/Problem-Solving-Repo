using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    internal class Program
    {
        static int ReadNumber()
        {
            int num = 0;
            Console.WriteLine("Enter a number");
            num = int.Parse(Console.ReadLine());

            return num;
        }

        static int SumOfDigit(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;  
            }

            return sum;
        }

        static void PrintSumOfDigit(int sum)
        {
            Console.WriteLine("The Sumation of the Number is: "+ sum);
        }

        static void Main(string[] args)
        {

            PrintSumOfDigit(SumOfDigit(ReadNumber()));

            Console.ReadKey();

        }
    }
}
