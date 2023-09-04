using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratePseudoNumberXOR
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int seed = 123;
            int randomNumber = seed;

            for (int i = 0; i < 10; i++)
            {
                randomNumber = randomNumber ^ (randomNumber << 13);
                randomNumber = randomNumber ^ (randomNumber >> 17);
                randomNumber = randomNumber ^ (randomNumber << 5);

                Console.WriteLine("Random Number: " + randomNumber);
            }


            Console.ReadKey();
        }
    }
}
