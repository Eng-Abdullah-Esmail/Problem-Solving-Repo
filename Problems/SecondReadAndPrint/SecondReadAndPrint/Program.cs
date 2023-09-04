using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondReadAndPrint
{
    internal class Program
    {
        static string ReadName()
        {
            string name;
            WriteLine("Enter your name to print it ");
            name = ReadLine();

            return name;
        }

        static void PrintName(string name)
        {
            WriteLine("Your Name is: " + name);
           
        }


        static void Main(string[] args)
        {
            PrintName(ReadName());

            ReadKey();
        }
    }
}
