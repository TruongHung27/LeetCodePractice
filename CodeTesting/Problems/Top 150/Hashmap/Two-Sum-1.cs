using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems.Top_150.Hashmap
{
    class Two_Sum_1
    {
        public int[] twoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int subValue = target - nums[i];

                if (map.TryGetValue(subValue,out int num))
                {
                    return new int[] { num, i };
                }

                if (!map.ContainsKey(nums[i])) 
                {
                    map.Add(nums[i], i);
                }
            }

            throw new ArgumentException("No two sum solution found");
        }
    }
}
