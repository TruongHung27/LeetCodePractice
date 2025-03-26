using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems
{
    class Is_Subsequence_392
    {
        public bool IsSubsequence(string s, string t)
        {

            if (string.IsNullOrEmpty(s)) return true;
            if (string.IsNullOrEmpty(t)) return false;

            int sPointer = 0;

            for (int i = 0; i < t.Length; i++)
            {
                if (s[sPointer] == t[i])
                {
                    sPointer++;

                    if (sPointer == s.Length)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        
    }
}
