using System;

namespace CodeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            var m = 3;
            int[] nums2 = new int[] { 2, 5, 6 };
            var n = 3;

            Merged_Sorted_Array_88 problem88 = new Merged_Sorted_Array_88();

            problem88.Merge(nums1,m,nums2,n);
        }
    }
}
