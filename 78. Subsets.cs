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

//Java
class Solution {
    public List<List<Integer>> subsets(int[] nums) {
        List<List<Integer>> result = new ArrayList<>();
        if(nums==null || nums.length==0){
            return result;
        }
        List<Integer> list = new ArrayList<>();
        dfs(result, list, 0, nums);
        return result;
    }
    public void dfs(List<List<Integer>> result,List<Integer> list, int start, int[] nums){
        result.add(new ArrayList<>(list));
        for(int i=start; i<nums.length;++i){
            list.add(nums[i]);
            dfs(result, list, i+1, nums);
            list.remove(list.size()-1);
        }
    }
}