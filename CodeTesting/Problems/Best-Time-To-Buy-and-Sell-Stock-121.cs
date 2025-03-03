using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice.Problems
{
    class Best_Time_To_Buy_and_Sell_Stock_121
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length < 2) return 0;

            int pointer1 = prices[0];
            int profit = 0;

            for(int pointer2 = 1; pointer2 < prices.Length; pointer2++)
            {
                int currentProfit = prices[pointer2] - pointer1;

                profit = Math.Max(profit, currentProfit);

                if(prices[pointer2] < pointer1)
                {
                    pointer1 = prices[pointer2];
                }
            }
            return profit;
        }
    }
}
