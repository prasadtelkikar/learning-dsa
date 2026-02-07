using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMaths
{
    public class FindGCDOfTwoNumbers
    {
        public static void Main(string[] args)
        {
            int n1 = 48;
            int n2 = 18;

            int result = FindGCDNonRecursive(n1, n2);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static int FindGCD(int n1, int n2)
        {
            for(int i = Math.Min(n1, n2); i >= 0; i--)
            {
                if (n1 % i == 0 && n2 % i == 0)
                    return i;
            }
            return 1;
        }

        private static int FindGCDRecursive(int n1, int n2)
        {
            if (n2 == 0)
                return n1;

            return FindGCDRecursive(n2, n1 % n2);
        }

        private static int FindGCDNonRecursive(int n1, int n2)
        {
            while(n2 != 0)
            {
                int rem = n1 % n2;
                n1 = n2;
                n2 = rem;
            }

            return n1;
        }
    }
}
