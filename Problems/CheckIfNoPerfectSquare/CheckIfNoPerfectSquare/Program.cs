using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfNoPerfectSquare
{
    internal class Program
    {
        static int ReadSquareNumber()
        {
            int num = 0;
            Console.WriteLine("Enter a number that is Square:");
            num = int.Parse(Console.ReadLine());

            return num;
        }
        static bool CheckPerfectSquare(int number)
        {
            double squareRoot = Math.Sqrt(number);
            return squareRoot % 1 == 0;
        }

        static void PrintResult(int num)
        {
            if (CheckPerfectSquare(num))
            {
                Console.WriteLine("The Number: " + num + " is Perfect Square");
            }
            else
            {
                Console.WriteLine("The Number: " + num + " is not Perfect Square");
            }
        }
        static void Main(string[] args)
        {
           PrintResult(ReadSquareNumber());

            Console.ReadKey();


        }
    }
}
