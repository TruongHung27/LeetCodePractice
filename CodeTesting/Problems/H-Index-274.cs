using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems
{
    class H_Index_274
    {
        public int HIndex(int[] citations)
        {
            Array.Sort(citations);
            Array.Reverse(citations);

            for (int i = 0; i < citations.Length; i++)
            {
                if (citations[i] <= i + 1)
                {
                    return i;
                }
            }

            return citations.Length;
        }
    }
}
