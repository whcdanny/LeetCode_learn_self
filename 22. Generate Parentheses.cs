/*Given n pairs of parentheses, write a function to generate all combinations of well-formed parentheses.

For example, given n = 3, a solution set is:

[
  "((()))",
  "(()())",
  "(())()",
  "()(())",
  "()()()"
]*/

/*思路：根据左括号的顺序和位置 来决定右括号的位置*/

public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        IList<string> result = new List<string>();

            GenerateParenthesis(0, 0, n, "", result);

            return result;
        }

        private void GenerateParenthesis(int currentLefts, int currentRights, int sum, string currentStr, IList<string> result)
        {
            if (currentRights == sum)
            {
                result.Add(currentStr);
            }

            if (currentLefts < sum)
            {
                GenerateParenthesis(currentLefts + 1, currentRights, sum, currentStr + "(", result);
            }

            if (currentLefts > currentRights)
            {
                GenerateParenthesis(currentLefts, currentRights + 1, sum, currentStr + ")", result);
            }
        }    
}