using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOddEvenAdvancedSolution
{
    enum OddOrEven
    {
        Even =0,
        Odd = 1
    }

    class CheckOdd
    {
        private int _value;
        private OddOrEven _even;


        private bool isOdd()
        {
            if (_value % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public CheckOdd(int value)
        {
            _value = value;
        }


        public OddOrEven State
        {
            get { 
            if(isOdd()) { return OddOrEven.Odd; }
                else
                {
                    return OddOrEven.Even;
                }
            
            }
                }

        private int ReadNumber()
        {
            int num;
            Console.Write("Enter  a  number\n");
            num = Convert.ToInt32(Console.ReadLine());

            return num;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            //CheckOdd ck = new CheckOdd(34);
            //if(ck.State == OddOrEven.Even)
            //{
            //    Console.WriteLine("it is even");
            //}
            //else
            //{
            //    Console.Write("Odd");
            //}


            Log.Logger = new LoggerConfiguration()
          .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)
          .CreateLogger();



            // Log a message
            Log.Information("Hello, Serilog!");

            // Flush the log and dispose the logger
            Log.CloseAndFlush();


            Console.ReadKey();
        }
    }
}
