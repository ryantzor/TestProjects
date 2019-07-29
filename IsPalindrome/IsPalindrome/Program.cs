using System;
using System.Linq;

namespace IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();
            Console.WriteLine(IsPalindrome(int.Parse(num)));
            
        }

        public static bool IsPalindrome(int x)
        {
            if (x < 0) return false;
            

            if (x == ReverseInt(x))
            {
                return true;
            }

            return false;

        }

        private static int ReverseInt(int x)
        {
            if (x == 0) return 0;

            bool isPositive = x > 0;
            int value = isPositive ? x : -x;  

            long reversed = 0;

            while (value > 0)
            {
                // pop each decimal 1 by 1
                var remainder = value % 10;
                value = value / 10;
                reversed = (reversed * 10) + remainder;
                // prevent overflow
                if (reversed > int.MaxValue) throw new OverflowException();
            }
            // return and maintain it's sign
            return (int)(isPositive ? reversed : -reversed);
        }
    }
}
