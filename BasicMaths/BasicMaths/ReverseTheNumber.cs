using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMaths
{
    public class ReverseTheNumber
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            int reversedNumber = CalculateReverseNumber(n);
            Console.WriteLine(reversedNumber);
            Console.ReadLine();
        }

        private static int CalculateReverseNumber(int n)
        {
            int reverseNumber = 0;
            while(n > 0)
            {
                var lastDigit = n % 10;
                reverseNumber = (reverseNumber * 10) + lastDigit;
                n /= 10;
            }
            return reverseNumber;
        }
    }
}
