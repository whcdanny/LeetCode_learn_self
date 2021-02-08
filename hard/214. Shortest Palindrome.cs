public class Solution {
    public string ShortestPalindrome(string s) {
        int len = s.Length;
        char[] sArray = s.ToCharArray();
        Array.Reverse(sArray);
        string rev = new string(sArray);
        for(int i = 0; i < len; i++)
        {
            if (s.Substring(0, len - i).Equals(rev.Substring(i)))
                return rev.Substring(0, i) + s;
        }
        return "";
    }
}

//Java
class Solution {
    public String shortestPalindrome(String s) {
        int n = s.length();
        String rev = new StringBuilder(s).reverse().toString();
        int j = 0;
        
        for (int i = 0; i < n; i++) {
            if (s.substring(0, n-i).equals(rev.substring(i))) 
                return rev.substring(0, i) + s;
        }
        return "";
    }
}