using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems
{
    class Word_Pattern_290
    {
        public bool WordPattern(string pattern, string s)
        {
            string[] words = s.Split(' ');

            if (pattern.Length != words.Length)
            {
                return false;
            }

            Dictionary<char, string> patternToWord = new Dictionary<char, string>();
            Dictionary<string, char> wordToPattern = new Dictionary<string, char>();

            for (int i = 0; i < pattern.Length; i++)
            {
                char currentChar = pattern[i];
                string currentWord = words[i];

                if (patternToWord.ContainsKey(currentChar))
                {
                    if (patternToWord[currentChar] != currentWord)
                    {
                        return false;
                    }
                }
                else
                {
                    patternToWord[currentChar] = currentWord;
                }

                if (wordToPattern.ContainsKey(currentWord))
                {
                    if (wordToPattern[currentWord] != currentChar)
                    {
                        return false;
                    }
                }
                else
                {
                    wordToPattern[currentWord] = currentChar;
                }

            }
            return true;
        }
    }
}
