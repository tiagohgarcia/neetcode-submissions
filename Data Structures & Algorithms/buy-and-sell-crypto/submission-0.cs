public class Solution {
    public int MaxProfit(int[] prices) {
        int left = 0;
        int max = 0;
        int profit = 0;

        for(int right = 0; right < prices.Length; right++) {
            profit = prices[right] - prices[left];
            if(profit > max) max = profit;

            if(profit < 0) left = right;
        }

        return max;
    }
}
