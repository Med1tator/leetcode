﻿using System;

namespace _001TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Solution().TwoSum(new int[4] { 2, 7, 11, 15 }, 9);
            Console.WriteLine($"{result[0]},{result[1]}");
        }
    }
    public class Solution
    {
        // 给定一个整数数组 nums和一个目标值 target，请你在该数组中找出和为目标值的那 两个整数，并返回他们的数组下标。
        // 你可以假设每种输入只会对应一个答案。但是，你不能重复利用这个数组中同样的元素。

        // 示例:
        // 给定 nums = [2, 7, 11, 15], target = 9
        // 因为 nums[0] + nums[1] = 2 + 7 = 9
        // 所以返回[0, 1]
        public int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > target)
                    continue;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        break;
                    }
                }
            }
            return result;
        }
    }
}
