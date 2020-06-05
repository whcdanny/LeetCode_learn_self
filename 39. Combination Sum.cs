/*Given a set of candidate numbers (candidates) (without duplicates) and a target number (target), find all unique combinations in candidates where the candidate numbers sums to target.

The same repeated number may be chosen from candidates unlimited number of times.

Note:

All numbers (including target) will be positive integers.
The solution set must not contain duplicate combinations.
Example 1:

Input: candidates = [2,3,6,7], target = 7,
A solution set is:
[
  [7],
  [2,2,3]
]
Example 2:

Input: candidates = [2,3,5], target = 8,
A solution set is:
[
  [2,2,2,2],
  [2,3,3],
  [3,5]
]*/

/*思路：一个一个来*/

public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        List<IList<int>> result = new List<IList<int>>();
        List<int> combination = new List<int>();
        Array.Sort(candidates);
        CombinationSum(result, candidates, combination, target, 0);
        return result;
    }

    private void CombinationSum(IList<IList<int>> result, int[] candidates, IList<int> combination, int target, int start)
    {
        if (target == 0)
        {
            result.Add(new List<int>(combination));
            return;
        }

        for (int i = start; i != candidates.Length && target >= candidates[i]; ++i)
        {
            combination.Add(candidates[i]);
            CombinationSum(result, candidates, combination, target - candidates[i], i);
            combination.Remove(combination.Last());
        }
    }    
}