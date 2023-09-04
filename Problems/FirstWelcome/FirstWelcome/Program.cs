using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWelcome
{
    internal class Program
    {
        static void PrintWelcome(string title)
        {
           WriteLine(title);
        }
        static void Main(string[] args)
        {
            PrintWelcome("Welcome To our First Program using C#");

            ReadKey();
        }
    }
}
