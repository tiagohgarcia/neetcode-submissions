class Solution {
public:
    int maxProfit(vector<int>& prices) {
        int buy = 0;
        int max_profit = 0;

        for(int sell = 0; sell < prices.size(); sell++) {
            if(prices[sell] < prices[buy]) { buy = sell; continue; }

            max_profit = max(max_profit, prices[sell] - prices[buy]);
        }

        return max_profit;
    }
};
