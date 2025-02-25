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

            Length_of_last_word_58 problem = new Length_of_last_word_58();

            problem.LengthOfLastWord(s);
        }
    }
}
