﻿using System;
using LeetCodePractice.Problems;

namespace CodeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {2, 3, 0,1,4};
            int[] nums2 = new int[] { 2, 4, 1 };
            int[] prices = new int[] {7, 1, 5, 3, 6, 4};
            int[] ciations = new int[] { 3, 0, 6, 1, 5 };

            string s = "a ";
            string haystack = "sadbutsad", needle = "sad";

            Integer_To_Roman_12 problem = new Integer_To_Roman_12();

            int i = 3749;

            problem.IntToRoman(i);
        }
    }
}
