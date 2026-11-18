public class Solution {
    public bool IsValid(string s) {
        if(s.Length % 2 != 0) return false;

        Stack<char> special = new(s.Length / 2);
        foreach(char c in s) {
            if(c == '(') special.Push(')');
            else if(c == '[') special.Push(']');
            else if(c == '{') special.Push('}');
            else {
                if(!special.TryPop(out char top) || top != c) return false;
            }
        }
        
        return special.Count == 0;
    }
}
