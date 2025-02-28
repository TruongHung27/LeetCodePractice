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

        public int StrStr_Improved(string haystack, string needle)
        {
            if (needle.Length == 0) return 0;
            if (haystack.Length < needle.Length) return -1;

            var haystackPointer = 0;
            var needlePointer = 0;
            var startIndex = -1;

            while (haystackPointer < haystack.Length)
            {
                if (haystack[haystackPointer] == needle[needlePointer])
                {
                    if (needlePointer == 0)
                    {
                        startIndex = haystackPointer;
                    }

                    needlePointer++;

                    if (needlePointer == needle.Length)
                    {
                        return startIndex;
                    }
                }
                else if (needlePointer > 0)
                {
                    haystackPointer = startIndex;
                    startIndex = -1;
                    needlePointer = 0;
                }

                haystackPointer++;
            }

            return -1;
        }
    }
}

