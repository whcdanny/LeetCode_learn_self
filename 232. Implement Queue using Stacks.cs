public class MyQueue {

    Stack<int> s1;
    Stack<int> s2;
    /** Initialize your data structure here. */
    public MyQueue() {
        s1 = new Stack<int>();
        s2 = new Stack<int>();
    }
    
    /** Push element x to the back of queue. */
    public void Push(int x) {
        while (s1.Count != 0)
        {
            s2.Push(s1.Pop());
        }
        s1.Push(x);
        while (s2.Count != 0)
        {
            s1.Push(s2.Pop());
        }
    }
    
    /** Removes the element from in front of queue and returns that element. */
    public int Pop() {
        return s1.Pop();
    }
    
    /** Get the front element. */
    public int Peek() {
        return s1.Peek();
    }
    
    /** Returns whether the queue is empty. */
    public bool Empty() {
        return (s1.Count == 0);
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
 
 
 //Java
 class MyQueue {
    Stack<Integer> s1;
    Stack<Integer> s2;

    /** Initialize your data structure here. */
    public MyQueue() {
        s1 = new Stack<>();
        s2 = new Stack<>();
    }
    
    /** Push element x to the back of queue. */
    public void push(int x) {
        while (!s1.isEmpty()) {
            s2.push(s1.pop());
        }
        s1.push(x);
        while (!s2.isEmpty()) {
            s1.push(s2.pop());
        }
    }
    
    /** Removes the element from in front of queue and returns that element. */
    public int pop() {
        return s1.pop();
    }
    
    /** Get the front element. */
    public int peek() {
        return s1.peek();
    }
    
    /** Returns whether the queue is empty. */
    public boolean empty() {
        return s1.isEmpty();
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.push(x);
 * int param_2 = obj.pop();
 * int param_3 = obj.peek();
 * boolean param_4 = obj.empty();
 */