using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EnterNameAndPrintItOnScreen
{
    internal class Program
    {
      public  class Person
        {
            private string _Name;

            public Person(string name)            {
                Print(name);
            }

            public static string ReadName()
            {
                string Name;
                Console.WriteLine("Enter Your Name");
                Name = Console.ReadLine();

                return Name;
            }

            public void Print(string text)
            {
                Console.WriteLine(text);
            }

        }
        static void Main(string[] args)
        {
            Person Abdullah = new Person(Person.ReadName());

            Console.ReadKey();
        }
    }
}
