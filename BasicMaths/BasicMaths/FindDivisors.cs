using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMaths
{
    public class FindDivisors
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            List<int> list = FindAllDivisors(n);
        }

        private static List<int> FindAllDivisors(int n)
        {
            List<int> result = new List<int>();
            for(int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                    result.Add(i);
                if(i != n / i)
                    result.Add(n / i);
            }
            return result;
        }
    }
}
