public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if (nums == null || nums.Length == 0)
            return new int[0];
        int[] result = new int[nums.Length - k + 1];
        LinkedList<int> deque = new LinkedList<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (deque.Count!=0 && deque.First.Value == i - k)
                deque.RemoveFirst();
            while (deque.Count != 0 && nums[i] >= nums[deque.Last.Value])
                deque.RemoveLast();
            deque.AddLast(i);
            if (i >= k - 1)
                result[i - k + 1] = nums[deque.First.Value];
        }
        return result;
    }
}

//Java
class Solution {
    public int[] maxSlidingWindow(int[] nums, int k) {
        if(nums == null || nums.length == 0) 
            return new int[0];
        int[] result = new int[nums.length - k + 1];
        LinkedList<Integer> deque = new LinkedList<>();
        for(int i = 0; i < nums.length; i++){
            if(!deque.isEmpty() && deque.peek() == i - k) 
                deque.poll();
            while(!deque.isEmpty() && nums[i] >= nums[deque.peekLast()]) 
                deque.pollLast();
            deque.offer(i);
            if(i >= k - 1) 
                result[i - k + 1] = nums[deque.peek()];
        }
        return result;
    }
}