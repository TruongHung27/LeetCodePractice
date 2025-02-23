using System;
using LeetCodePractice.Problems;

namespace CodeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 7, 1, 5, 3 ,7 ,4};
            int[] nums2 = new int[] { 2,4,1};

            Best_Time_To_Buy_and_Sell_Stock_121 problem = new Best_Time_To_Buy_and_Sell_Stock_121();

            problem.MaxProfit(nums);
        }
    }
}
