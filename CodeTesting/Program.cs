using System;
using LeetCodePractice.Problems;

namespace CodeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {1,2,3,4,5};
            int[] nums2 = new int[] { 3,4,5,1,2};
            int[] prices = new int[] {7, 1, 5, 3, 6, 4};
            int[] ciations = new int[] { 3, 0, 6, 1, 5 };

            string s = "PAYPALISHIRING";
            string haystack = "sadbutsad", needle = "sad";

            ZigZag_Conversion_6 problem = new ZigZag_Conversion_6();

            int i = 3749;

            problem.Convert(s,3);
        }
    }
}
