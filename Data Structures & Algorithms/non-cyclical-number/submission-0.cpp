class Solution {
public:
    bool isHappy(int n) {
        if(n == 1) return true;

        bool happy = false;
        unordered_set<int> seen;

        while(!happy) {
            seen.insert(n);
            n = calculateSums(n);

            if(seen.contains(n)) break;
            if(n == 1) happy = true;
        }
        return happy;
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
