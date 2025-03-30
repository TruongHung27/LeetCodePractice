using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems.Top_150.Hashmap
{
    class Random_Note_383
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> letterCount = new Dictionary<char, int>();

            foreach (char c in magazine)
            {
                if (letterCount.ContainsKey(c))
                    letterCount[c]++;
                else
                    letterCount[c] = 1;
            }

            foreach (char c in ransomNote)
            {
                if (!letterCount.ContainsKey(c) || letterCount[c] == 0)
                    return false;
                letterCount[c]--;
            }
            return true;
        }
    }
}
