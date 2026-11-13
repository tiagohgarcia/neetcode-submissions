public class Solution {
    public bool IsValid(string s) {
        Stack<char> special = new Stack<char>();

        foreach(char c in s) {
            if(c == '(') special.Push(')');
            else if(c == '{') special.Push('}');
            else if(c == '[') special.Push(']');
            else if(special.Count == 0 || special.Pop() != c) return false;
        }

        return special.Count == 0;
    }
}
