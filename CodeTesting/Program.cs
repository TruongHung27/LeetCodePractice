using System;
using LeetCodePractice.Problems;

namespace CodeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {1, 2, 3, 4, 5, 6, 7};
            int[] nums2 = new int[] { 2, 4, 1 };
            int[] prices = new int[] {7, 1, 5, 3, 6, 4};

            string s = "a ";
            string haystack = "sadbutsad", needle = "sad";

            Rotate_Array_189 problem= new Rotate_Array_189();

            problem.Rotate(nums,3);
        }
    }
}
