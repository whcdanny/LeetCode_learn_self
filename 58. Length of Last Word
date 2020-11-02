public class Solution {
    public int LengthOfLastWord(string s) {
        s = s.Trim(); //意思是去掉字符串的头尾的空格
        int l = 0;
        foreach(char c in s){
            if(c==' ')
                l = 0;
            else
                l++;
        }
        return l;
    }
}

//Python3
class Solution:
    def lengthOfLastWord(self, s: str) -> int:
        return len(s.strip().split(' ')[-1])// strip是去掉字符串的头尾的空格