using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetCodePractice.Problems
{
    class Valid_Palindrome_125
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return true;

            s = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();

            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                if (s[left] != s[right])
                    return false;
                left++;
                right--;
            }

            return true;
        }


        //Logic works but slow
        //public bool IsPalindrome(string s)
        //{
        //    if (s == "") return true;

        //    StringBuilder starterString = new StringBuilder();
        //    StringBuilder endString = new StringBuilder();
        //    s = Regex.Replace(s, @"[^a-zA-z0-9]", "");
        //    s = s.ToLower();

        //    int startPointer = 0;
        //    int endPointer = s.Length - 1;
        //    while(startPointer != s.Length && endPointer != s.Length)
        //    {
        //        starterString.Append(s[startPointer]);
        //        endString.Append(s[endPointer]);

        //        startPointer++;
        //        endPointer--;
        //    }

        //    if(starterString.ToString() == endString.ToString())
        //    {
        //        return true;
        //    }

        //    return false;
        //}
    }
}
