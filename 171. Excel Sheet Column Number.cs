public class Solution {
    public int TitleToNumber(string s) {
        if (s.Length == 0 || s == null)
            return 0;
        int res = 0;
        for(int i=0; i<s.Length; i++)
        {
            int cur = (int)(s.ToCharArray()[i]-'A')+1;
            res = 26*res+cur;
        }
        return res;
    }
}

//Java
class Solution {
    public int titleToNumber(String s) {
        int num = 0;
        int pow = 0;
        for (int i = s.length() - 1; i >= 0; i--) {
            num += ((int) Math.pow(26, pow++)) * (s.charAt(i) - 'A' + 1);
        }
        return num;
    }
}

//C++
class Solution {
public:
    int titleToNumber(string s) {
        int sum=0;
        int tmp=0;
        for(int i=0; i<s.length(); i++){
            tmp=s[i]-'A'+1;
            sum=26*sum+tmp;
        }
        return sum;
    }
};