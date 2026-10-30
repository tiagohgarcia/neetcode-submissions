class Solution {
    bool happy = false;
    unordered_set<int> seen;
public:
    bool isHappy(int n) {
        if(n == 1) return true;
        if(seen.contains(n)) return false;

        seen.insert(n);
        n = calculateSums(n);
        return isHappy(n);
    }

    int calculateSums(int val) {
        int sum = 0;
        while(val > 0) {
            int digit = val % 10;
            sum += (digit * digit);
            val /= 10;
        }
        return sum;
    }
};
