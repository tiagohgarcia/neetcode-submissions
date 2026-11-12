class Solution {
public:
    int lengthOfLongestSubstring(string s) {
        unordered_set<char> used;
        int left = 0;
        int longest = 0;

        for(int right = 0; right < s.size(); right++) {
            while(used.contains(s[right])) {
                used.erase(s[left]);
                left++;
            }
            used.insert(s[right]);
            longest = max(longest, right - left + 1);
        }

        return longest;
    }
};
