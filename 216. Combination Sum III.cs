public class Solution {
    public IList<IList<int>> CombinationSum3(int k, int n) {
        IList<IList<int>> res = new List<IList<int>>();
        List<int> sub = new List<int>();
        dfs(res, 1, sub, k, n);
        return res;
    }
    private void dfs(IList<IList<int>> res, int index, List<int> sub, int k, int n)
    {
        if (sub.Count == k)
        {
            if (n == 0)
            {
                res.Add(new List<int>(sub));
            }
            return;
        }
        for(int i=index; i <= 9; i++)
        {
            sub.Add(i);
            dfs(res, i + 1, sub, k, n-i);
            sub.Remove(i);
        }
    }
}


//Java
class Solution {
    public List<List<Integer>> combinationSum3(int k, int n) {
        List<List<Integer>> subset = new ArrayList();
        dfs(subset,1,new ArrayList(),k,n);
        return subset;
    }
    public void dfs(List<List<Integer>> subset , int index ,List<Integer> current,int k,int target){        
        if(current.size()==k){
            if(target==0){
              subset.add(new ArrayList(current));
            }
            return;
        }                
        
        for(int i = index;i<=9;i++){
            current.add(i);
            dfs(subset,i+1,current,k,target-i);
            current.remove(current.size()-1);
        }      
    }
}