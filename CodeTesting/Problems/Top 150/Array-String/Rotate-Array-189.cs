using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems
{
    class Rotate_Array_189
    {
        //Idea
        //Use two pointers,
        //Iterate through the array while it is less then second pointer
        public void Rotate(int[] nums,int k)
        {
            if (nums == null || nums.Length == 0 || k <= 0) return;

            //if length is 3, k = 2 is the same as k = 5
            k = k % nums.Length;

            if (k == 0) return;

            //Idea, filp the entire array
            //[1,2,3,4,5] = [5,4,3,2,1]
            //One thing to notice is that this way, the end of the array is at the beginning and the end of the array is at the end
            reverseHelper(nums, 0, nums.Length - 1);

            //Now reverse the beginning of the array
            //[4,5,3,2,1]
            reverseHelper(nums, 0, k - 1);

            //Now reverse the end of the array
            //[4,5,1,2,3]
            reverseHelper(nums, k, nums.Length - 1);

        }

        private void reverseHelper(int[] nums, int start, int end)
        {
            while(start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}
