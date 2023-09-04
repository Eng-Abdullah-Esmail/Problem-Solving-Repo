using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PrintName
{
    internal class Program
    {
        class PrintName
        {
            private string _Name;
            
           public PrintName(string name)
            {
                Print(name);
            }

            public void Print(string Name, string Msg= "Hello, ")
            {
                Console.WriteLine( Msg + " "+ Name);
            }
        }
        static void Main(string[] args)
        {
            PrintName MyName = new PrintName("Abdullah Abdo Mohammed Esmail");

            Console.ReadKey();
        }
    }
}
