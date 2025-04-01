using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems.Top_150.Hashmap
{
    class Happy_Number_202
    {
        public bool IsHappy(int n)
        {
            HashSet<int> hasNumber = new HashSet<int>();

            while (n != 1)
            {
                if (hasNumber.Contains(n))
                {
                    return false;
                }

                hasNumber.Add(n);

                n = GetNextNumber(n);

            }

            return true;
        }

        private int GetNextNumber(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum += digit * digit;
                num /= 10;
            }

            return sum;
        }
    }
}
