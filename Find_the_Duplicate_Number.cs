/*Find the Duplicate Number*/
public class Solution {
    public int FindDuplicate(int[] nums) {
        List<int> _A = new List<int>(nums);
            _A.Sort();
            int res = 0;
            for (int i = 0; i < _A.Count; i++)
            {
                if (_A[i] == _A[i + 1])
                {
                    res = _A[i];
                    break;
                }
            }
            return res;
    }
}