using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMaths
{
    public class NumberIsPalindrome
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            bool isPalindrom = IsPalindrom(n);
            Console.WriteLine(isPalindrom ? $"{n} is a Palindrome" : $"{n} is not a Palindrome");
            Console.ReadLine();
        }

        private static bool IsPalindrom(int n)
        {
            int reverseNumber = 0;
            int nCopy = n;
            while (nCopy > 0)
            {
                int lastDigit = nCopy % 10;
                reverseNumber = reverseNumber * 10 + lastDigit;
                nCopy = nCopy / 10;
            }

            return n == reverseNumber;
        }
    }
}
