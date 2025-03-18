using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems
{
    class Reverse_Words_in_String_151
    {
        public string ReverseWords(string s)
        {
            string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder builder = new StringBuilder();

            for(int i = words.Length - 1; i >= 0; i--)
            {
                if(i == words.Length - 1)
                {
                    builder.Append(words[i]);
                }
                else
                {
                    builder.Append(" " + words[i]);
                }
            }

            return builder.ToString();
        }
    }
}
