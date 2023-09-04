using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIFOddOrEven
{
    internal class Program
    {
        public class OddEven
        {
            private int _Number;

            public OddEven() { }

            public int ReadNumber()
            {
                int number;
                Console.WriteLine("Enter a Number to Test it if its Odd or Event :");
                number = Convert.ToInt32(Console.ReadLine());

                return number;
            } 
            public bool isEven(int number)
            {
                if (number % 2 == 0)
                    return true;
                else
                    return false;
            }
            public void Print(bool number)
            {
                if (number)
                    Console.WriteLine("it is Event");
                else
                    Console.WriteLine("it is Odd");
            }
        }
        static void Main(string[] args)
        {
            OddEven num = new OddEven();
            num.Print(num.isEven(num.ReadNumber()));

            Console.ReadKey();
        }
    }
}
