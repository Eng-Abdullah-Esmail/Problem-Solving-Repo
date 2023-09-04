using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxWithinArray
{
    internal class Program
    {

        static void PrintMessage(string message ="")
        {
            Console.WriteLine(message);
        }
        static int ReadNumber(string msg)
        {
            int number = 0;
            Console.Write(msg);
            number= int.Parse(Console.ReadLine());
            
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


        static int FindMaximum(int[] array)
        {
            int maximum = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maximum)
                    maximum = array[i];
            }

            return maximum;
        }

        static void PrintMax(int max)
        {
            Console.WriteLine("Max Of Item within Array: " + max);
        }
        static void Main(string[] args)
        {
            int[] items = ReadItems(ReadNumber("Enter the size of Array"));

            PrintMax(FindMaximum(items));


            Console.ReadKey();
        }
    }
}
