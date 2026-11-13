public class Solution {
    public int CoinChange(int[] coins, int amount) {
        int[] memo = new int[amount + 1];
        Array.Fill(memo, -1);
        
        if(amount == 0) return 0;
        memo[0] = 0;

        for(int i = 1; i <= amount; i++) {
            for(int j = 0; j < coins.Length; j++) {
                if(coins[j] <= i) {
                    int subresult = memo[i - coins[j]];
                    
                    if(subresult == -1) continue; // not possible
                    
                    if(memo[i] == -1 || memo[i] > 1 + subresult) 
                        memo[i] = 1 + subresult;
                }
            }
        }
        

        return memo[amount];
    }
}
