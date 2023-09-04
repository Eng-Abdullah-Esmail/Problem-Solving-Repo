using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveOrNegativeNumber
{
    internal class Program
    {
        public class Number
        {
            private int _Number;

            public Number() { }

            public void SetNumber(int value) {
                _Number = value;
            }

            public void Print() {
                if(_Number < 0)
                {
                    Console.WriteLine("it is Negative");

                }
                else
                {
                    Console.WriteLine("it is Postive");
                }
            }
}



        
        static void Main(string[] args)
        {
            Number number = new Number();
            number.SetNumber(34);
            number.Print();

            Console.ReadKey();
        }
    }
}
