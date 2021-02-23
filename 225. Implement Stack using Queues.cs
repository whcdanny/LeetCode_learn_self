public class MyStack {
    private Queue<int> queue;
    private Queue<int> queue_top;

    /** Initialize your data structure here. */
    public MyStack() {
        queue = new Queue<int>();
        queue_top = new Queue<int>();
    }
    
    /** Push element x onto stack. */
    public void Push(int x) {
        queue.Enqueue(x);
        while (queue_top.Count != 0)
        {
            queue.Enqueue(queue_top.Dequeue());
        }
        while (queue.Count != 0)
        {
            queue_top.Enqueue(queue.Dequeue());
        }
    }
    
    /** Removes the element on top of the stack and returns that element. */
    public int Pop() {
        int res = queue_top.Dequeue();
        if (res != 0)
            return res;
        return -1;
    }
    
    /** Get the top element. */
    public int Top() {
        return queue_top.Peek();
    }
    
    /** Returns whether the stack is empty. */
    public bool Empty() {
        return queue_top.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
 
 
 class MyStack {
    private Queue<Integer> queue;
    private Queue<Integer> queue_top;

    /** Initialize your data structure here. */
    public MyStack() {
        queue = new LinkedList<>();
        queue_top = new LinkedList<>();
    }
    
    /** Push element x onto stack. */
    public void push(int x) {
        queue.offer(x);
        while (!queue_top.isEmpty()) {
            queue.offer(queue_top.poll());
        }
        while (!queue.isEmpty()) {
            queue_top.offer(queue.poll());
        }
    }
    
    /** Removes the element on top of the stack and returns that element. */
    public int pop() {
        Integer ret = queue_top.poll();
        if (ret != null)
            return ret;
        return -1;
    }
    
    /** Get the top element. */
    public int top() {
        return queue_top.element();
    }
    
    /** Returns whether the stack is empty. */
    public boolean empty() {
        return queue_top.size() == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.push(x);
 * int param_2 = obj.pop();
 * int param_3 = obj.top();
 * boolean param_4 = obj.empty();
 */