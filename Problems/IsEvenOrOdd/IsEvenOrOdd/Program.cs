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
            WriteLine("Enter a number to check if Even or not");
            num = int.Parse(ReadLine());

            return num;
        }
        static bool IsEven(int num)
        {
            if (num %2== 0)
                return true;
            else
                return false;
        }

        static void PrintResult(bool isEven)
        {
            if (isEven)
                WriteLine("It is Even");
            else
                WriteLine("It is Odd");

        }

        static void Main(string[] args)
        {
            PrintResult(IsEven(ReadNumber()));

            ReadKey();
        }
    }
}
