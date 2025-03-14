using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems
{
    class Integer_To_Roman_12
    {
        public string IntToRoman(int num)
        {
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            StringBuilder romanString = new StringBuilder();

            for (int i = 0; i < values.Length; i++)
            {
                while (num >= values[i])
                {
                    romanString.Append(symbols[i]);
                    num -= values[i];
                }
            }

            return romanString.ToString();
        }
    }
}
