namespace Patterns
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            PatternPrinter.PrintAlphabetInRowRightAngleTraingle(n);
            Console.ReadKey();
        }
    }
}