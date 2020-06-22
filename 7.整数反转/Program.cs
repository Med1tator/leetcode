using System;

namespace _7.整数反转
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        public int Reverse(int x)
        {
            var ans = 0;
            int ifMax = int.MaxValue / 10, ifMin = int.MinValue / 10;

            while (x != 0)
            {
                if (ans > ifMax || ans < ifMin)
                {
                    return 0;
                }

                ans = ans * 10 + x % 10;
                x /= 10;
            }

            return ans;
        }
    }
}
