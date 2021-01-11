public class Solution {
    public IList<IList<string>> Partition(string s) {
        IList<IList<string>> res = new List<IList<string>>();
        IList<string> cur = new List<string>();
        dfs(s, 0, cur, res);
        return res;
    }
    public void dfs(string s, int start, IList<string> cur, IList<IList<string>> res)
    {
        if (start == s.Length)
        {
            res.Add(new List<string>(cur));
            return;
        }
        for(int i=start; i<s.Length; i++)
        {
            if(isPartition(s, start, i))
            {
                cur.Add(s.Substring(start, i - start + 1));
                dfs(s, i + 1, cur, res);
                cur.RemoveAt(cur.Count - 1);
            }
        }
    }

    public bool isPartition(string s, int start, int end)
    {
        while (start < end)
        {
            if (s[start] != s[end])
            {
                return false;
            }
            ++start;
            --end;
        }
        return true;
    }
}

//C++
class Solution {
public:
    vector<vector<string>> partition(string s) {
        vector<vector<string>> result;
        vector<string> list;
        dfs(s,0,list,result);
        return result;
    }
    void dfs(string s, int start, vector<string> &list, vector<vector<string>> &result){
        if(start==s.size()){
            result.push_back(list);
            return;
        }
        for(int i=start; i<s.size(); ++i){
            if(isPartition(s, start, i)){
                list.push_back(s.substr(start, i-start+1));
                dfs(s, i+1, list, result);
                list.pop_back();
            }
        }
    }
    bool isPartition(string s, int start, int end){
        while(start<end){
            if(s[start]!=s[end]){
                return false;
            }
            ++start;
            --end;
        }
        return true;
    } 
};