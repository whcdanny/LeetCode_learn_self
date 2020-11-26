public class Solution {
    public bool IsInterleave(string s1, string s2, string s3) {
        var res = new bool[s1.Length + 1, s2.Length + 1];
        if (s3.Length != s1.Length + s2.Length)
        {
            return false;
        }
        
        for (var i = 0; i <= s1.Length; i++)
        {
            for (var j = 0; j <= s2.Length; j++)
            {
                if (i == 0 && j == 0)
                {
                    res[i, j] = true;
                    continue;
                }
                
                res[i, j] = j > 0 && res[i, j - 1] && s2[j - 1] == s3[i + j - 1] || 
                                     i > 0 && res[i - 1, j] && s1[i - 1] == s3[i + j - 1];
            }
        }
        
        return res[s1.Length, s2.Length];
    }
}