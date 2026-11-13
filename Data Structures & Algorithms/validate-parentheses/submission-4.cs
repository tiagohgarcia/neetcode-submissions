public class Solution {
    public bool IsValid(string s) {
        Stack<char> special = new Stack<char>();

        foreach(char c in s) {
            if(c == '(') special.Push(')');
            else if(c == '{') special.Push('}');
            else if(c == '[') special.Push(']');
            else
            {
                if(special.Count == 0) return false;
                
                if(c == special.Peek()) special.Pop();
                else return false;
            }
        }

        return special.Count == 0;
    }
}
