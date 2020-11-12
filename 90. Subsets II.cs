public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        System.Array.Sort(nums);
        SubsetsWithDup(result, new List<int>(), nums, 0);

        return result;
    }
    private void SubsetsWithDup(IList<IList<int>> result, List<int> list, int[] nums, int start)
    {
        result.Add(new List<int>(list));

        for (int i = start; i < nums.Length; i++)
        {
            if (i > start && nums[i] == nums[i - 1]) 
                continue;

            list.Add(nums[i]);
            SubsetsWithDup(result,list, nums, i + 1);
            list.RemoveAt(list.Count - 1);
        }
    }
}