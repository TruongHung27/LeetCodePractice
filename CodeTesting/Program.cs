using System;
using LeetCodePractice.Problems;

namespace CodeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 7, 1, 5, 3, 7, 4 };
            int[] nums2 = new int[] { 2, 4, 1 };
            int[] prices = new int[] {7, 1, 5, 3, 6, 4};

            string s = "a ";
            string haystack = "sadbutsad", needle = "sad";

            Best_Time_To_Buy_and_Sell_Stock_122 problem= new Best_Time_To_Buy_and_Sell_Stock_122();

            problem.MaxProfit_2(prices);
        }
    }
}
