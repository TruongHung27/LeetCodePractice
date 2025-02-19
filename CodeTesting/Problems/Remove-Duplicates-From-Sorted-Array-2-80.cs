using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems
{
    class Remove_Duplicates_From_Sorted_Array_2_80
    {

        /// <summary>
        /// My Initial Solution
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int RemoveDuplicates(int[] nums)
        {
            int p1 = 0;
            int dupCounter = 0;

            for(int p2 = 0; p2 < nums.Length;p2++)
            {
                if(p2 == 5)
                {
                    Console.WriteLine(p2);
                }
                
                if(dupCounter == 2 && nums[p2] != nums[p1 - 1])
                {
                    dupCounter = 0;
                }

                if(dupCounter == 1 && nums[p2] != nums[p2 - 1])
                {
                    dupCounter = 0;
                }

                if(nums[p2] >= nums[p1] && dupCounter < 2)
                {
                    nums[p1] = nums[p2];
                    p1++;
                    dupCounter++;
                }
            }

            return p1;
        }

        /// <summary>
        /// Improved Space and Time Complexity
        /// Understand that Because we are allowing two values, we can check pointer1 - 2 to see if they are the same
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int ImpovedRemoveDuplicates(int[] nums)
        {
            if (nums.Length <= 2) return nums.Length;

            int p1 = 2;

            for (int p2 = 2; p2 < nums.Length; p2++)
            {
                if(nums[p2] != nums[p1 - 2])
                {
                    nums[p1] = nums[p2];
                    p1++;
                }
            }

            return p1;
        }
    }
}
