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

        public static void PrintSymmatricVoidPattern(int n)
        {
            int spaces = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n-i); j++)
                    Console.Write('*');
                for (int k = 0; k < spaces; k++)
                    Console.Write(' ');
                for (int l = 0; l < (n-i); l++)
                    Console.Write('*');
                spaces += 2;
                Console.WriteLine();
            }
            spaces -= 2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                    Console.Write('*');
                for (int k = 0; k < spaces; k++)
                    Console.Write(' ');
                for (int l = 0; l <= i; l++)
                    Console.Write('*');
                spaces -= 2;
                Console.WriteLine();
            }
        }

        public static void PrintSymmatricButterflyPattern(int n)
        {
            int spaces = (n-1) * 2;
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j <=i; j++)
                    Console.Write('*');
                for (int k = 0; k < spaces; k++)
                    Console.Write(' ');
                for (int l = 0; l <= i; l++)
                    Console.Write('*');

                spaces -= 2;
                Console.WriteLine();
            }
            spaces = 2;
            for(int i = 1;i < n; i++)
            {
                for (int j = 0; j < (n-i); j++)
                    Console.Write('*');
                for (int k = 0; k < spaces; k++)
                    Console.Write(' ');
                for (int l = 0; l < (n-i); l++)
                    Console.Write('*');

                spaces += 2;
                Console.WriteLine();
            }
        }
        public static void PrintNumberPattern(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(i == 0 || i == n-1)
                        Console.Write('*');
                    else if (j == 0 || j == n-1)
                        Console.Write('*');
                    else
                        Console.Write(' ');                        
                }
                Console.WriteLine();
            }
        }

        public static void PrintNumberBoxPattern(int n)
        {
            int size = 2*n - 1;
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j < size; j++)
                {
                    int top = i;
                    int bottom = (size - 1) - i;

                    int left = j;
                    int right = (size - 1) - j;

                    int value = n - Math.Min(
                        Math.Min(top, bottom), 
                        Math.Min(right, left));

                    Console.Write(value);
                }
                Console.WriteLine();
            }
        }
        
    }
}
