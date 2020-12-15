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

//Java
class Solution {
    public List<List<Integer>> combine(int n, int k) {
        List<List<Integer>> res = new ArrayList<>();
        if (n <= 0)
            return res;
        List<Integer> subRes = new ArrayList<>();

        DFS(res, subRes, n, k, 1);
        return res;
    }
    private static void DFS(List<List<Integer>> res, List<Integer> subRes, int n, int k, int start)
    {
        if (k==0)
        {
            res.add(new ArrayList<Integer>(subRes));
            return;
        }
        
        for (int i = start; i <= n ; i++)
        {
            subRes.add(i);
            DFS(res, subRes, n, k-1, i+1);
            subRes.remove(subRes.size()-1); 
        }
    }
}