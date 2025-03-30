using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems.Top_150.Hashmap
{
    class Valid_Anagram_242
    {
        public bool IsAnagram(string s, string t)
        {
            //First though
            //Use Dictonary Of Char, Int 
            // Use two loops to first get get all the charafters in S then second loop to remove the characters.

            if (s.Length != t.Length) return false;


            Dictionary<char, int> validChar = new Dictionary<char, int>();

            for(int i = 0; i < s.Length; i++)
            {
                if(validChar.TryGetValue(s[i],out int count))
                {
                    validChar[s[i]] = count + 1;
                }
                else
                {
                    validChar.Add(s[i], 1);
                }
            }

            for(int i = 0; i < t.Length; i++)
            {
                if(validChar.TryGetValue(t[i], out int count))
                {
                    validChar[t[i]] = count - 1;

                    if(validChar[t[i]] < 0)
                    {
                        return false;
                    }
                }
                else
                {
                    //char was not in dictonary thus it cannot be an anagram
                    return false;
                }
            }

            foreach (var count in validChar.Values)
            {
                if(count != 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
