public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        List<IList<int>> res = new List<IList<int>>();
        if (nums == null || nums.Length == 0)
        {
            return res;
        }

        List<int> subRes = new List<int>();

        Recruion(res, nums, subRes, 0);

        return res;
    }
    private void Recruion(List<IList<int>> res, int[] nums, List<int> subRes, int start)
    {
        res.Add(new List<int>(subRes));           
        for (int i = start; i < nums.Length; i++)
        {
            subRes.Add(nums[i]);
            Recruion(res, nums, subRes, i + 1);
            subRes.RemoveAt(subRes.Count - 1);
        }
    }
}