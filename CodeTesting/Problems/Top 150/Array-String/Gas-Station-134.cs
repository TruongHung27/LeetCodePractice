using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems
{
    class Gas_Station_134
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            if (gas.Length != cost.Length) return -1;

            int totalGas = 0;
            int totalCost = 0;
            int currentGas = 0;
            int startIndex = 0;

            for (int i = 0; i < gas.Length; i++)
            {
                totalGas += gas[i];
                totalCost += cost[i];

                currentGas += gas[i] - cost[i];
                if (currentGas < 0)
                {
                    startIndex = i + 1;
                    currentGas = 0;
                }
            }

            // If total gas is less than total cost, no solution exists
            return totalGas >= totalCost ? startIndex : -1;



            //Logic works but is O(n^2) and too slow

            //if (gas.Length > Math.Pow(10, 4) || cost.Length > Math.Pow(10, 4)) return -1;
            //if (gas.Length != cost.Length) return -1;


            //for (int j = 0; j < gas.Length; j++)
            //{
            //    int gasTank = 0;
            //    bool canComplete = true;

            //    for (int i = 0; i < gas.Length; i++)
            //    {
            //        int currentIndex = (j + i) % gas.Length;
            //        gasTank += gas[currentIndex];

            //        if(gasTank < cost[currentIndex])
            //        {
            //            canComplete = false;
            //            break;
            //        }

            //        gasTank -= cost[currentIndex];
            //    }

            //    if (canComplete)
            //    {
            //        return j;
            //    }

            //}
            //return -1;
        }
    }
}
