using System;

class Program
{
    static int FindGCD(int num1, int num2)
    {
        while (num2 != 0)
        {
            int remainder = num1 % num2;
            num1 = num2;
            num2 = remainder;
        }

        return num1;
    }

    static void Main()
    {
        int a = 12;
        int b = 18;
        int gcd = FindGCD(a, b);

        Console.WriteLine("GCD of " + a + " and " + b + ": " + gcd);

        Console.ReadKey();


    }
}