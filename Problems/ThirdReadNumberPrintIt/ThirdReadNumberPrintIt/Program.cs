using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdReadNumberPrintIt
{
    internal class Program
    {
        static int ReadNumber()
        {
            int num = 0;
            WriteLine("Please Enter a number to print it");
            num = int.Parse(ReadLine() + "\n");
            return num;
        }

        static void PrintNumber(int num)
        {
            WriteLine("Number is: " + num);
        }

        static void Main(string[] args)
        {
            PrintNumber(ReadNumber());

            ReadKey();
        }
    }
}
