namespace BasicMaths
{
    public class CountDigits
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()!);
            int digitCount = CountDigitsUsingLog(n);

            Console.WriteLine(digitCount);
            Console.ReadLine();
        }

        private static int CountDigitsInNumber(int n)
        {
            int count = 0;
            while(n > 0)
            {
                count++;
                n = n / 10;
            }
            return count;
        }

        private static int CountDigitsUsingLog(int n)
        {
            int count = (int)Math.Log10(n) + 1;
            return count;
        }
    }
}