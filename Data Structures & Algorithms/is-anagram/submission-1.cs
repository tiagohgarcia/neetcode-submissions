public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        var frequencies = new int[26];

        for(int i = 0; i < s.Length; i++) {
            frequencies[s[i] - 'a']++;
            frequencies[t[i] - 'a']--;
        }

        foreach(int freq in frequencies) {
            if(freq != 0) return false;
        }

        return true;
    }
}
