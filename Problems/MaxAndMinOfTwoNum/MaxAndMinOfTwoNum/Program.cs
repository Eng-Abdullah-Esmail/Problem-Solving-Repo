using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxAndMinOfTwoNum
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


        static int GetMax(int num1, int num2)
        {
            return (num1>num2) ? num1 : num2;
        }

        static int GetMin(int num1, int num2)
        {
            return (num1 < num2) ? num1 : num2;
        }

        static void Print(int num, string msg)
        {
            WriteLine(msg + " " + num);
        }

        static void Main(string[] args)
        {
            int num1 = ReadNumber("Enter First Number");
            int num2 = ReadNumber("Enter Second number");
            Print(GetMax(num1,num2), "Max Num is:");
            Print(GetMin(num1, num2), "Min Num is:");


            ReadKey();
        }
    }
}
