using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems
{
    class Length_of_last_word_58
    {
        public int LengthOfLastWord(string s)
        {
            var length = 0;

            for(int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] == ' ' && length > 0)
                {
                    return length;
                }
                if(s[i] != ' ')
                {
                    length++;
                }
            }

            return length;
        }
    }
}
