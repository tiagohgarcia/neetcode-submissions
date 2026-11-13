public class Solution {
    public int CoinChange(int[] coins, int amount) {
        if(amount == 0) return 0;

        int[] dp = new int[amount + 1];
        Array.Fill(dp, amount + 1);
        dp[0] = 0;

        for(int a = 1; a <= amount; a++) {
            foreach(int c in coins) {
                if(c <= a) {
                    dp[a] = Math.Min(dp[a], 1 + dp[a - c]);
                }
            }
        }

        return dp[amount] > amount ? -1 : dp[amount];
    }
}
