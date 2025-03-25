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

            string s = "A man, a plan, a canal: Panama";
            string haystack = "sadbutsad", needle = "sad";

            Valid_Palindrome_125 problem = new Valid_Palindrome_125();

            int i = 3749;

            problem.IsPalindrome(s);
        }
    }
}
