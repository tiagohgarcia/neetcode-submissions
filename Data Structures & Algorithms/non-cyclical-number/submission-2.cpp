class Solution {
public:
    bool isHappy(int n) {
        unordered_set<int> seen;
        while(n != 1 && !seen.contains(n)) {
            seen.insert(n);
            n = calculateSums(n);
        }
        return n == 1;
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
