using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems
{
    class Product_Of_Array_Except_Self_238
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] result = new int[nums.Length];

            int leftProduct = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = leftProduct;
                leftProduct *= nums[i];
            }

            int rightProduct = 1;
            for (int i = nums.Length; i >= 0; i--)
            {
                result[i] *= rightProduct;
                rightProduct *= nums[i];
            }

            return result;
        }
    }
}
