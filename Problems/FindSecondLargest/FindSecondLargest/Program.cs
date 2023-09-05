using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSecondLargest
{
    internal class Program
    {
        static int FindSecondLargest(int[] nums)
        {
            int firstsecond = int.MinValue;
            int secondlargest = int.MinValue;


            foreach (int number in nums)
            {
                if (number > firstsecond)
                {
                    secondlargest = firstsecond;
                    firstsecond = number;
                }
                else if (number > secondlargest && number != firstsecond)
                {
                    secondlargest = number;
                }
            }

            return secondlargest;
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 10, 2, 8, 15 };
            int secondLargest = FindSecondLargest(arr);

            Console.WriteLine("Second largest number: " + secondLargest);

            Console.ReadKey();
        }
    }
}
