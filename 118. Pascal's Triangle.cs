public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        IList<IList<int>> res = new List<IList<int>>();
        if (numRows == 0)
        {
            return res;
        }
        List<int> list = new List<int>();
        list.Add(1);
        res.Add(list);
        for(int i=2; i<=numRows; i++)
        {
            List<int> curList = new List<int>();
            curList.Add(1);
            IList<int> temp = new List<int>();
            temp = res[res.Count-1];
            for(int j=1; j<i-1; j++)
            {
                curList.Add(temp[j - 1] + temp[j]);
            }
            curList.Add(1);
            res.Add(curList);
        }
        return res;
    }
}

//Java
class Solution {
    public List<List<Integer>> generate(int numRows) {
        List<List<Integer>> res = new ArrayList<List<Integer>>();
        if(numRows==0){
            return res;
        }
        List<Integer> list0 = new ArrayList<Integer>();
        list0.add(1);
        res.add(list0);
        
        for(int i=2; i<=numRows; i++){
            List<Integer> list = new ArrayList<Integer>();
            list.add(1);
            List<Integer> temp = res.get(res.size()-1);
            for(int j=1; j<i-1; j++){
                list.add(temp.get(j-1)+temp.get(j));
            }
            list.add(1);
            res.add(list);
        }
        return res;
    }
}