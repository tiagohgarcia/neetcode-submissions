public class MinStack {
    private readonly Stack<int> main = new();
    private readonly Stack<int> extra = new();

    public MinStack() {
        
    }
    
    public void Push(int val) {
        main.Push(val);

        if(extra.Count > 0)
            extra.Push(Math.Min(val, extra.Peek()));
        else
            extra.Push(val);
    }
    
    public void Pop() {
        main.Pop();
        extra.Pop();
    }
    
    public int Top() {
        return main.Peek();
    }
    
    public int GetMin() {
        return extra.Peek();
    }
}
