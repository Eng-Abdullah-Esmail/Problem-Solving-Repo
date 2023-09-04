using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveOrNegativeNum
{
    internal class Program
    {
        static int ReadNumber()
        {
            int num = 0;
            WriteLine("Enter a number to check if positive or not");
            num = int.Parse(ReadLine());

            return num;
        }
        static bool IsPositive(int num)
        {
            if(num > 0)
                return true;
            else
                return false;
        }

        static void PrintResult(bool isPositive)
        {
            if (isPositive)
                WriteLine("It is Positive");
            else
                WriteLine("It is Negative");
            
        }

        static void Main(string[] args)
        {
            PrintResult(IsPositive(ReadNumber()));

            ReadKey();
        }
    }
}
