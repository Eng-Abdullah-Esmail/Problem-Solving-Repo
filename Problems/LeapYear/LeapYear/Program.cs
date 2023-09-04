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
            int year = 0;
            WriteLine("Enter a Year to check if Leap  or not");
            year = int.Parse(ReadLine());

            return year;
        }
        static bool IsLeap(int year)
        {
            if((year %4 ==0 &&  year %100 != 0) ||(year %400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void PrintResult(bool isleap)
        {
            if (isleap)
                WriteLine("It is Leap Year");
            else
                WriteLine("It is Not leap Year");

        }

        static void Main(string[] args)
        {
            PrintResult(IsLeap(ReadNumber()));

            ReadKey();
        }
    }
}
