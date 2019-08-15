using System;
using System.Collections.Generic;

namespace _003IsPalindorme
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();

            #region MyRegion
            //Console.WriteLine(s.IsPalindrome(121));
            //Console.WriteLine(s.IsPalindrome(111));
            //Console.WriteLine(s.IsPalindrome(10));
            //Console.WriteLine(s.IsPalindrome(-121)); 
            #endregion

            #region MyRegion
            //Console.WriteLine(s.RomanToInt("III"));
            //Console.WriteLine(s.RomanToInt("IV"));
            //Console.WriteLine(s.RomanToInt("IX"));
            //Console.WriteLine(s.RomanToInt("LVIII"));
            //Console.WriteLine(s.RomanToInt("MCMXCIV"));
            #endregion

            #region MyRegion
            var str1 = "a".Substring(0, 0);
            var str2 = "a".Substring(0, 1);
            Console.WriteLine(s.LongestCommonPrefix(new string[3] { "freabc", "freqwe", "fremnb" }));
            Console.WriteLine(s.LongestCommonPrefix(new string[2] { "a", "b" }));
            Console.WriteLine(s.LongestCommonPrefix(new string[2] { "aa", "aa" }));
            #endregion
        }
    }
}

public class Solution
{
    //public bool IsPalindrome(int x)
    //{
    //    if (x < 0)
    //        return false;

    //    var reversVal = 0;
    //    var xVal = x;
    //    while (xVal > 0)
    //    {
    //        var pop = xVal % 10;
    //        xVal /= 10;

    //        reversVal = reversVal * 10 + pop;
    //    }

    //    return reversVal == x;
    //}

    public bool IsPalindrome(int x)
    {
        if (x < 0 || (x % 10 == 0 && x != 0))
            return false;

        var reversVal = 0;
        while (x > reversVal)
        {
            reversVal = reversVal * 10 + x % 10;
            x /= 10;
        }

        return x == reversVal || x == reversVal / 10;
    }

    public int RomanToInt(string s)
    {
        var dict = new Dictionary<char, int>
        {
            { 'M', 1000 },
            { 'D', 500 },
            { 'C', 100 },
            { 'L', 50 },
            { 'X', 10 },
            { 'V', 5 },
            { 'I', 1 }
        };

        var chars = s.ToCharArray();

        var ans = dict[chars[chars.Length - 1]];
        for (int i = 0; i < chars.Length - 1; i++)
        {
            if (dict[chars[i]] < dict[chars[i + 1]])
            {
                ans -= dict[chars[i]];
                continue;
            }

            ans += dict[chars[i]];
        }

        return ans;
    }

    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0 || string.IsNullOrEmpty(strs[0]))
            return string.Empty;

        if (strs.Length == 1)
            return strs[0];

        var ans = strs[0].Substring(0, 1);

        while (ans.Length <= strs[0].Length)
        {
            for (int i = 1; i < strs.Length; i++)
            {
                if (strs[i].IndexOf(ans) != 0)
                {
                    return ans.Substring(0, ans.Length - 1);
                }
            }

            if (ans.Length == strs[0].Length)
                break;

            ans = strs[0].Substring(0, ans.Length + 1);
        }

        return ans;
    }
}
