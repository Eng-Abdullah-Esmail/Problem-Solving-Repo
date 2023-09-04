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


        static int[] ReadArray(int size)
        {

            int[] array = new int[size];

            Console.WriteLine("Enter the elements:");

            for (int i = 0; i < size; i++)
            {

                array[i] = ReadNumber("Element " + (i + 1) + ": ");
            }

            return array;

        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine("\n \nItems Of The Array is:\n ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Element " + (i + 1) + ": " + array[i]);
            }
        }


        static void Main(string[] args)
        {
            PrintArray(ReadArray(ReadNumber("Enter the Number Of Items: ")));


            Console.ReadKey();
        }
    }
}
