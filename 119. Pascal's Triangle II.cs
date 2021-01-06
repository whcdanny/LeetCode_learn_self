public class Solution {
    public IList<int> GetRow(int rowIndex) {
        IList<IList<int>> res = new List<IList<int>>();
        List<int> list = new List<int>();
        list.Add(1);
        res.Add(list);
        if (rowIndex == 0)
        {
            return res[0];
        }
            
        for (int i = 2; i <= rowIndex+1; i++)
        {
            List<int> curList = new List<int>();
            curList.Add(1);
            IList<int> temp = new List<int>();
            temp = res[res.Count - 1];
            for (int j = 1; j < i - 1; j++)
            {
                curList.Add(temp[j - 1] + temp[j]);
            }
            curList.Add(1);
            res.Add(curList);
        }
        return res[rowIndex];
    }
}

//Java
class Solution {
    public List<Integer> getRow(int rowIndex) {
        List<List<Integer>> res = new ArrayList<List<Integer>>();
        List<Integer> res1 = new ArrayList<Integer>();
        if(rowIndex==0){
            res1.add(1);
            return res1;
        }
        List<Integer> list0 = new ArrayList<Integer>();
        list0.add(1);
        res.add(list0);
        
        for(int i=2; i<=rowIndex+1; i++){
            List<Integer> list = new ArrayList<Integer>();
            list.add(1);
            List<Integer> temp = res.get(res.size()-1);
            for(int j=1; j<i-1; j++){
                list.add(temp.get(j-1)+temp.get(j));
            }
            list.add(1);
            res.add(list);
        }
        res1=res.get(rowIndex);
        return res1;
    }
}