/*Given a collection of candidate numbers (candidates) and a target number (target), find all unique combinations in candidates where the candidate numbers sums to target.

Each number in candidates may only be used once in the combination.

Note:

All numbers (including target) will be positive integers.
The solution set must not contain duplicate combinations.
Example 1:

Input: candidates = [10,1,2,7,6,1,5], target = 8,
A solution set is:
[
  [1, 7],
  [1, 2, 5],
  [2, 6],
  [1, 1, 6]
]
Example 2:

Input: candidates = [2,5,2,1,2], target = 5,
A solution set is:
[
  [1,2,2],
  [5]
]*/

/*思路：类似combination sum 只不过加一个筛选 不要重复的*/
public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        var result = new List<IList<int>>();
        if (candidates.Length == 0) return result;
        Array.Sort(candidates);
        DFS(candidates, target, 0, new List<int>(), result);
        return result;
    }

    private void DFS(int[] candidates, int target, int start, IList<int> oneResult, IList<IList<int>> result) {
        if (target == 0) {
            result.Add(new List<int>(oneResult));
        } 
        else if (target > 0) {
            for (int i = start; i < candidates.Length; i++) {
                // NOTE: NOT if (i > 0)
                if (i > start && candidates[i - 1] == candidates[i]) continue;
                oneResult.Add(candidates[i]);
                DFS(candidates, target - candidates[i], i + 1, oneResult, result);
                oneResult.RemoveAt(oneResult.Count - 1);
            }
        }
    }
}