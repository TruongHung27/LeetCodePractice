using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems
{
    class Remove_Duplicates_From_Sorted_Array_26
    {
        public int RemoveDuplicates(int[] nums)
        {
            int p1 = 0;

            for (int p2 = 1; p2 < nums.Length; p2++)
            {
                if (nums[p2] != nums[p1])
                {
                    nums[p1++] = nums[p2];
                }
            }
            return p1 + 1;
        }
    }
}
