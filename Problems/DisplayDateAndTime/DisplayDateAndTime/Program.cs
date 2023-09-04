using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayDateAndTime
{
   

    public class Program
    {
        public static void Main()
        {
            DateTime currentDateTime = GetCurrentDateTime();
            DisplayDateTime(currentDateTime);


            Console.ReadKey();

        }

        private static DateTime GetCurrentDateTime()
        {
            DateTime currentDateTime = DateTime.Now;
            return currentDateTime;
        }

        private static void DisplayDateTime(DateTime dateTime)
        {
            Console.WriteLine($"Current Date and Time: {dateTime}");
        }
    }
}
