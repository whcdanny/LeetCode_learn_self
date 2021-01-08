public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums == null || nums.Length == 0)
                return 0;
        int length = nums.Length;
        HashSet<int> pool = new HashSet<int>();
        foreach (int n in nums)
            pool.Add(n);
        int max = 0;
        foreach (int i in pool)
        {
            int temp = i;
            if (!pool.Contains(i - 1))
            {
                int count = 1;

                while (pool.Contains(++temp))
                {
                    count++;                        
                }
                max = Math.Max(count, max);
            }
        }
        return max;
    }
}

//Java
class Solution {
    public int longestConsecutive(int[] nums) {
        if(nums == null || nums.length == 0) return 0;
        int len = nums.length;
        Set<Integer> pool = new HashSet<>();
        for(int n : nums)
            pool.add(n);
        int max = 0;
        for(Integer i : pool){
            if(!pool.contains(i - 1)){
                int count = 1;
                while(pool.contains(++i)){
                    count++;
                }
                max = Math.max(count, max);
            }
        }
        return max;
    }
}