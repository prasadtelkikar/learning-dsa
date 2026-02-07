using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMaths
{
    public class CheckNumberIsArmstrong
    {
        public static void Main(string[] args)
        {
            int n = 153;
            bool isArmstrong = FindArmstrongNumber(n);

            Console.WriteLine(isArmstrong ? "Number is an Armstrong number" : "Number is not an Armstrong Number");
            Console.ReadLine();
        }

        private static bool FindArmstrongNumber(int n)
        {
            int power = n.ToString().Length;
            double armStrongNumber = 0;
            int temp = n;
            while(n > 0)
            {
                var rem = n % 10;
                armStrongNumber += Math.Pow(rem, power);
                n = n / 10;
            }

            return armStrongNumber == temp;
        }
    }
}
