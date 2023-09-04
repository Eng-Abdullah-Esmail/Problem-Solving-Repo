using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxWithinArray
{
    internal class Program
    {

        static void PrintMessage(string message = "")
        {
            Console.WriteLine(message);
        }
        static int ReadNumber(string msg)
        {
            int number = 0;
            Console.Write(msg);
            number = int.Parse(Console.ReadLine());

            return number;
        }


        static int[] ReadItems(int size)
        {

            int[] array = new int[size];

            Console.WriteLine("Enter the elements:");

            for (int i = 0; i < size; i++)
            {

                array[i] = ReadNumber("Element " + (i + 1) + ": ");
            }

            return array;

        }


        static int FindMinimum(int[] array)
        {
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
            }

            return min;
        }

        static void PrintMin(int min)
        {
            Console.WriteLine("Min  Item within Array: " + min);
        }
        static void Main(string[] args)
        {
            int[] items = ReadItems(ReadNumber("Enter the size of Array: "));

            PrintMin(FindMinimum(items));


            Console.ReadKey();
        }
    }
}
