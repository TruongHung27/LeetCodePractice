using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems
{
    class Jump_Game2
    {
        public int Jump(int[] nums)
        {
            if (nums.Length <= 1) return 0;

            int jumps = 0;
            int currentMaxReach = 0;
            int nextMaxReach = 0;

            for(int i = 0; i < nums.Length - 1; i++)
            {
                nextMaxReach = Math.Max(nextMaxReach, i + nums[i]);

                if(i == currentMaxReach)
                {
                    jumps++;

                    currentMaxReach = nextMaxReach;

                    if(currentMaxReach >= nums.Length - 1)
                    {
                        return jumps;
                    }
                }
            }
            return jumps;
        }
    }
}
