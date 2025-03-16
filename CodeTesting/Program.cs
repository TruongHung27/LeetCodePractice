using System;
using LeetCodePractice.Problems;

namespace CodeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {1,2,3,4};
            int[] nums2 = new int[] { -1,1,0,-3,3};
            int[] prices = new int[] {7, 1, 5, 3, 6, 4};
            int[] ciations = new int[] { 3, 0, 6, 1, 5 };

            string s = "a ";
            string haystack = "sadbutsad", needle = "sad";

            Product_Of_Array_Except_Self_238 problem = new Product_Of_Array_Except_Self_238();

            int i = 3749;

            problem.ProductExceptSelf(nums2);
        }
    }
}
