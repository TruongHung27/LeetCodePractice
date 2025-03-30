using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems
{
    class Jump_Game_55
    {
        public bool CanJump(int[] nums)
        {
            int lastPos = nums.Length - 1;

            for(int i = nums.Length - 2; i >= 0; i--)
            {
                if(i + nums[i] >= lastPos)
                {
                    lastPos = i;
                }
            }

            return lastPos == 0;
        }

    }
}
