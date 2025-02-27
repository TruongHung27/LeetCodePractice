using System;

namespace LeetCodePractice.Problems
{
    class First_Occurance_In_String_28
    {
        public int StrStr(string haystack, string needle)
        {
            if (haystack.Length <= 0 && needle.Length <= 0) return -1;

            return haystack.IndexOf(needle);
        }
    }
}

