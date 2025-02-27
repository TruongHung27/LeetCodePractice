using System;
using LeetCodePractice.Problems;

namespace CodeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 7, 1, 5, 3 ,7 ,4};
            int[] nums2 = new int[] { 2,4,1};

            string s = "a ";
            string haystack = "adbutsad", needle = "bob";

            First_Occurance_In_String_28 problem= new First_Occurance_In_String_28();

            problem.StrStr(haystack,needle);
        }
    }
}
