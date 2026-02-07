using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMaths
{
    public class FindPrimeNumber
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            bool isPrime = CheckPrimeNumber(n);
        }

        private static bool CheckPrimeNumber(int n)
        {
            int count = 0;
            for(int i = 1; i <= Math.Sqrt(n); i++)
            {
                if(n % i == 0)
                    count++;

                // If n is not a perfect square, count its reciprocal factor
                // Every divisor comes in pairs, except the square root — which comes alone. -> Here just count another element in the pair.
                if (n / i != i)
                    count++;
            }

            return count == 2;
        }
    }
}
