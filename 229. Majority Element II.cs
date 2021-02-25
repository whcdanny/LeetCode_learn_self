public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        Dictionary<int, int> list = new Dictionary<int, int>();
        foreach(int val in nums)
        {
            if (list.ContainsKey(val))
                list[val]++;
            else
                list.Add(val, 1);
            }
        IList<int> res = new List<int>();
        foreach(int val in list.Keys)
        {
            int check = nums.Length / 3;
            if (list[val] > check)
                res.Add(val);
        }
        return res;
    }
}

//Java
class Solution {
    public List<Integer> majorityElement(int[] nums) {
        Map<Integer, Integer> counterMap = new HashMap();
        for (int i = 0; i < nums.length; i++) {
            if (counterMap.containsKey(nums[i])) {
                counterMap.put(nums[i], counterMap.get(nums[i]) + 1);
            } else {
                counterMap.put(nums[i], 1);
            }
        }
        int size = nums.length;
        List<Integer> result = new ArrayList<>();
        for (Integer i : counterMap.keySet()) {
            int threshold = size / 3;
            if (counterMap.get(i) > threshold) {
                result.add(i);
            }
        }
        return result;
    }
}