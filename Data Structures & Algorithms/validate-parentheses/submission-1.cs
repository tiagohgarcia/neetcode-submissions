public class Solution {
    public bool IsValid(string s) {
        Stack<char> sequence = new Stack<char>();

        foreach(char c in s) {
            if(c == '(' || c == '{' || c == '[') {
                sequence.Push(c);
                continue;
            }
            
            if(!sequence.Any()) return false;
            char last = sequence.Pop();
            if((c == ')' && last == '(') ||
               (c == '}' && last == '{') ||
               (c == ']' && last == '[')) {
                continue;
            }

            return false;
        }

        return !sequence.Any();
    }
}
