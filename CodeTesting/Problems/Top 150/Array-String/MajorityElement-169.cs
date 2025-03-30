using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems
{
    class MajorityElement_169
    {
        public int MajorityElement(int[] nums)
        {
            int majority = Math.Abs(nums.Length / 2);
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            foreach (var item in nums)
            {
                if(keyValuePairs.ContainsKey(item))
                {
                    keyValuePairs[item]++;
                    if (keyValuePairs[item] > majority)
                    {
                        return item;
                    }
                }
                else
                {
                    keyValuePairs[item] = 1;
                }
            }

            return 0;
        }
    }
}
