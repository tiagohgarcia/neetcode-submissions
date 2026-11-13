public class Solution {    
    public int ClimbStairs(int n) {     
        int[] memo = new int[n + 1];
        return Climb(n, memo);
    }

    private int Climb(int n, int[] memo) {
        if(memo[n] != 0) return memo[n];
        
        int result = 0;
        if(n == 0) result = 0;
        else if(n == 1) result = 1;
        else if(n == 2) result = 2;  
        else result = Climb(n - 1, memo) + Climb(n - 2, memo);
        
        memo[n] = result;

        return result;
    }
}
