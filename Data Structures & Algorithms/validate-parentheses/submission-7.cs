public class Solution {
    public bool IsValid(string s) {
        if(s.Length == 1) return false;

        Stack<char> special = new(s.Length);
        foreach(char c in s) {
            if(c == '(') special.Push(')');
            else if(c == '[') special.Push(']');
            else if(c == '{') special.Push('}');
            else {
                if(special.Count == 0 || special.Peek() != c) return false;
                special.Pop();
            }
        }
        
        return special.Count == 0;
    }
}
