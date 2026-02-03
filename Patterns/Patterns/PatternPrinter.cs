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
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        public static void RightAngleNumbers(int n)
        {
            for (int i = 0; i < n; i++)
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
            for (int i = 0; i < n; i++)
            {
                for (int j = n; j > i; j--)
                    Console.Write('*');
                Console.WriteLine();
            }
        }

        public static void ReverseRightAngleNumbers(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n-i); j++)
                    Console.Write(j+1);
                Console.WriteLine();
            }
        }

        public static void PrintTraingle(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n-i); j++)
                    Console.Write(" ");
                for (int k = 0; k < (i*2+1); k++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }

        public static void PrintMirrorImageTraingle(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write(" ");
                for (int k = 0; k < (2*n - (2*i+1)); k++)
                    Console.Write('*');
                Console.WriteLine();
            }
        }

        public static void PrintPartialDiamand(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write('*');
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n-i-1); j++)
                    Console.Write('*');
                Console.WriteLine();
            }
        }

        public static void PrintFullDiamand(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n-i-1); j++)
                    Console.Write(' ');
                for (int k = 0; k < (2*i+1); k++)
                    Console.Write('*');
                Console.WriteLine();
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write(' ');
                for (int k = 0; k < (2*n - (2*i+1)); k++)
                    Console.Write('*');
                Console.WriteLine();
            }
        }

        public static void PrintBinaryRightAngle(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    char bit = (i + j) % 2 == 0 ? '1' : '0';
                    Console.Write(bit);
                }
                Console.WriteLine();
            }
        }
        
        public static void PrintEmptyTraingleInBetween(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write(j+1);
                for (int k = 0; k < (2*n - 2*(i+1)); k++)
                    Console.Write('*');
                for(int l = (i+1); l > 0; l--)
                    Console.Write(l);
                Console.WriteLine();
            }
        }

        public static void PrintIncrementalRightAngle(int n)
        {
            int counter = 1;
            for(int i = 0; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                    Console.Write($"{counter++} ");
                Console.WriteLine();
            }
        }

        public static void PrintAlphabetsInRightAngleTraingle(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(char ch = 'A'; ch <= 'A'+i; ch++)
                    Console.Write(ch);
                Console.WriteLine();
            }
        }

        public static void PrintAlphabetInReverseRightAngleTraingle(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for (char ch = 'A'; ch < 'A'+(n-i); ch++)
                    Console.Write(ch);
                Console.WriteLine();
            }
        }

        public static void PrintAlphabetInRowRightAngleTraingle(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write((char)('A'+i));
                Console.WriteLine();
            }
        }
    }
}
