public class MinStack {

    /** initialize your data structure here. */
    Stack<int> stack = new Stack<int>();
    Stack<int> minStack = new Stack<int>();

    public MinStack()
    {

    }

    public void Push(int x)
    {
        stack.Push(x);
        if (minStack.Count == 0 || x <= GetMin())
            minStack.Push(x);
    }

    public void Pop()
    {
        if (stack.Count == 0)
            return;
        int x = stack.Pop();
        if (x == minStack.Peek())
            minStack.Pop();
    }

    public int Top()
    {
        return stack.Peek();
    }

    public int GetMin()
    {
        return minStack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
 
 //Java
 class MinStack {
    Stack<Integer> stack = new Stack();
    Stack<Integer> minStack = new Stack(); // keeps track of minimums

    /** initialize your data structure here. */
    public MinStack() {
        
    }
    
    public void push(int x) {
        stack.push(x);
        if (minStack.isEmpty() || x <= getMin()) {
            minStack.push(x);
        }
    }
    
    public void pop() {
        if (stack.isEmpty()) {
            return;
        }
        int x = stack.pop();
        if (x == minStack.peek()) {
            minStack.pop();
        }
    }
    
    public int top() {        
        return stack.peek();
    }
    
    public int getMin() {
        return minStack.peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.push(x);
 * obj.pop();
 * int param_3 = obj.top();
 * int param_4 = obj.getMin();
 */