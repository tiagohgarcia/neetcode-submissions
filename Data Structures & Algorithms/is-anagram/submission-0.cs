public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;

        var frequencies = new Dictionary<char, int>();

        foreach(char c in s) {
            if(frequencies.ContainsKey(c)) 
            {
                frequencies[c]++;
                continue;
            }
            frequencies.Add(c, 1);
        }

        foreach(char c in t) {
            if(!frequencies.ContainsKey(c)) return false;
            frequencies[c]--;
        }

        foreach(var (key, value) in frequencies) {
            if(value != 0) return false;
        }

        return true;
    }
}
