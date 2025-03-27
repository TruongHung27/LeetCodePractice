using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems
{
    class Isomorphic_Strings_205
    {
        public bool IsIsomorphic(string s, string t)
        {
            Dictionary<char, char> sValuePairs = new Dictionary<char, char>();
            Dictionary<char, char> tValuePairs = new Dictionary<char, char>();

            if(s.Length == t.Length)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    var sChar = s[i];
                    var tChar = t[i];

                    if(sValuePairs.ContainsKey(sChar))
                    {
                        if (sValuePairs[sChar] != tChar)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        sValuePairs[sChar] = tChar;
                    }

                    if(tValuePairs.ContainsKey(tChar))
                    {
                        if(tValuePairs[tChar] != sChar)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        tValuePairs[tChar] = sChar;
                    }
                }
            }
            return true;
        }
    }
}
