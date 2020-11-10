public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
         List<IList<int>> res = new List<IList<int>>();

        int[] subRes = new int[k];

        Recruion(res, k, n, subRes, 1);

        return res;
    }
     private void Recruion(List<IList<int>> res, int k, int n, int[] subRes, int start)
    {
        if (k == 0)
        {
            res.Add(subRes.ToList());
            return;
        }
        for(int i = start; i<=n; i++)
        {
            subRes[subRes.Length - k] = i;
            Recruion(res, k - 1, n, subRes, i + 1);
        }
    }
}