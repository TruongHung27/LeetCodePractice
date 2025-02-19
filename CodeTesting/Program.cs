using System;
using LeetCodePractice.Problems;

namespace CodeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 0, 0, 1, 1, 1, 1, 2, 3, 3};

            Remove_Duplicates_From_Sorted_Array_2_80 problem = new Remove_Duplicates_From_Sorted_Array_2_80();

            problem.RemoveDuplicates(nums);
        }
    }
}
