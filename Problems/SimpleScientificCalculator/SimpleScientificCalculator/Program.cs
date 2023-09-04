using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleScientificCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Scientific Calculator");

            while (true)
            {
                Console.WriteLine("Enter an operation (+, -, *, /, sqrt, pow, sin, cos, tan, exit):");
                string operation = Console.ReadLine();

                if (operation == "exit")
                {
                    break;
                }

                if (operation == "sqrt")
                {
                    Console.WriteLine("Enter a number:");
                    double number = double.Parse(Console.ReadLine());
                    double result = Math.Sqrt(number);
                    Console.WriteLine("Result: " + result);
                }
                else if (operation == "pow")
                {
                    Console.WriteLine("Enter the base:");
                    double baseNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the exponent:");
                    double exponent = double.Parse(Console.ReadLine());
                    double result = Math.Pow(baseNumber, exponent);
                    Console.WriteLine("Result: " + result);
                }
                else if (operation == "sin")
                {
                    Console.WriteLine("Enter an angle in degrees:");
                    double angle = double.Parse(Console.ReadLine());
                    double result = Math.Sin(angle * Math.PI / 180);
                    Console.WriteLine("Result: " + result);
                }
                else if (operation == "cos")
                {
                    Console.WriteLine("Enter an angle in degrees:");
                    double angle = double.Parse(Console.ReadLine());
                    double result = Math.Cos(angle * Math.PI / 180);
                    Console.WriteLine("Result: " + result);
                }
                else if (operation == "tan")
                {
                    Console.WriteLine("Enter an angle in degrees:");
                    double angle = double.Parse(Console.ReadLine());
                    double result = Math.Tan(angle * Math.PI / 180);
                    Console.WriteLine("Result: " + result);
                }
                else
                {
                    Console.WriteLine("Enter the first number:");
                    double num1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the second number:");
                    double num2 = double.Parse(Console.ReadLine());

                    double result = 0;
                    switch (operation)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            result = num1 / num2;
                            break;
                        default:
                            Console.WriteLine("Invalid operation");
                            break;
                    }

                    Console.WriteLine("Result: " + result);
                }
            }

            Console.ReadKey();
        }
    }
}
