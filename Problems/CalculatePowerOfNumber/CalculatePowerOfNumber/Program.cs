using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatePowerOfNumber
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

        static int CalculatePower(int num, int exponent)
        {
            int power = 1;
            for(int i = 1; i <= exponent; i++)
            {
                power *= num;
            }

            return power;
        }

        static void PrintPower(int pow)
        {
            WriteLine("The Power is :"+ pow);
        }

        static void Main(string[] args)
        {
            PrintPower(CalculatePower(ReadNumber("Enter number"), ReadNumber("Enter the Exponent")));


            ReadKey();
        }
    }
}
