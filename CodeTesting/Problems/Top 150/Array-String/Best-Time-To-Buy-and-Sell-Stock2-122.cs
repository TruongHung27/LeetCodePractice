using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems
{
    class Best_Time_To_Buy_and_Sell_Stock_122
    {
        //Utilize Greedy Approch
        //Since we can buy and sell stocks on the same day
        //Selling at every increase will result in maximum profit
        public int MaxProfit_2(int[] prices)
        {
            if (prices.Length < 2) return 0;
            int profit = 0;
    
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i-1])
                {
                    profit += prices[i] - prices[i - 1];
                }
            }

            return profit;
        }
    }
}
