public class Solution {
    public bool IsValid(string s) {
        if(s.Length % 2 != 0) return false;
         
        Stack<char> sequence = new Stack<char>();
        foreach(char c in s) {
            switch(c) {
                case '(': sequence.Push(')'); break;
                case '{': sequence.Push('}'); break;
                case '[': sequence.Push(']'); break;
                default:
                    if(sequence.Count == 0 || sequence.Pop() != c) return false;
                    break;
            }
        }

        return sequence.Count == 0;
    }
}
