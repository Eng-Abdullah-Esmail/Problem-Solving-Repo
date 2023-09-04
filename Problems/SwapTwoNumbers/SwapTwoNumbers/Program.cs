using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoNumbers
{
    

    class Program
    {
        static void Main()
        {
           
            int num1 = ReadNumber("Enter the First Number: ");

           
            int num2 = ReadNumber("Enter the Second Number: ");

            Console.WriteLine("\nBefore swapping:\n");
            Console.WriteLine("First number: " + num1);
            Console.WriteLine("Second number: " + num2);

            SwapNumbers(ref num1, ref num2);

            Console.WriteLine("\nAfter swapping:\n");
            Console.WriteLine("First number: " + num1);
            Console.WriteLine("Second number: " + num2);



            Console.ReadKey();
        }


        static int ReadNumber(string msg)
        {
            int num = 0;
            Console.Write(msg);
            num = int.Parse(Console.ReadLine());

            return num;
        }

        static void SwapNumbers(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}
