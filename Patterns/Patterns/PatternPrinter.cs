using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public static class PatternPrinter
    {
        public static void Square(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        public static void RightAngle(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        public static void RightAngleNumbers(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write(j+1);
                Console.WriteLine();
            }
        }

        public static void RightAngleSameNumberPerLine(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write(i+1);
                Console.WriteLine();
            }
        }

        public static void ReverseRightAngle(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = n; j > i; j--)
                    Console.Write('*');
                Console.WriteLine();
            }    
        }
    }
}
