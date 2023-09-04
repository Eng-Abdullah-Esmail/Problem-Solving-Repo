using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMissingNoinArray
{
    internal class Program
    {
        static int FindMissingNumber(int[] items)
        {
            int n = items.Length+1 ;
            int ExpectedSum = n * (n + 1) / 2;
            int ActualSum = 0;
            foreach(int num in items)
            {
                ActualSum += num;
            }

            return ExpectedSum - ActualSum;

        }


        //public static void FindMissingNumbers(int[] nums)
        //{
        //    int n = nums.Length + 2; // Expected number of consecutive numbers
        //    int expectedSum = (n * (n + 1)) / 2; // Sum of consecutive numbers from 1 to n
        //    int actualSum = 0;

        //    foreach (int num in nums)
        //    {
        //        actualSum += num;
        //    }

        //    int missingSum = expectedSum - actualSum; // Sum of the two missing numbers
        //    int missingProduct = 1;

        //    foreach (int num in nums)
        //    {
        //        missingSum -= num;
        //        if (missingSum % num == 0)
        //        {
        //            missingProduct *= num;
        //        }
        //    }

        //    int a = (int)Math.Sqrt(missingProduct);
        //    int b = missingSum / a;

        //    Console.WriteLine("Missing Numbers: " + a + ", " + b);
        //}



        static void Main(string[] args)
        {
            int[] item = {1,2,3,4,5,7,8,9,10};
            //FindMissingNumbers(item);
            //Console.WriteLine(Math.Sqrt(8));
             Console.WriteLine(FindMissingNumber(item).ToString());


            Console.ReadKey();


        }
    }
}
