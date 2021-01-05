public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int length = strs.Length;
        string res = "";
        if (length == 0)
            return res;
        Array.Sort(strs);
        int end = Math.Min(strs[0].Length, strs[length - 1].Length);
        for (int i=0; i<end; i++)
        {
            for(int j = 0; j < length; j++)
            {
                if(strs[j][i] != strs[0][i])
                {
                    return res;
                }
            }
            res += strs[0][i];
        }
        return res;
    }
}

//C++
class Solution {
public:
    string longestCommonPrefix(vector<string>& strs) {
        int length = strs.size();
        string result;
        if(length==0){
            return result;
        }
        for(int i=0; i<strs[0].size(); i++){
            for(int j=0;j<length;j++){
                if(strs[j].size()==i||strs[j][i]!=strs[0][i]){
                    return result;
                }
            }
            result.push_back(strs[0][i]);
        }
        return result;
    }
};