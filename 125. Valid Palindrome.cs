public class Solution {
    public bool IsPalindrome(string s) {
        int left = 0;
        int right = s.Length - 1;

        while (left < right)
        {
            if (!isAlp(s[left])){
                left++;
                continue;
            }
            if (!isAlp(s[right]))
            {
                right--;
                continue;
            }
            if (char.ToLower(s[left]).Equals(char.ToLower(s[right])))
            {
                left++;
                right--;
                continue;
            }
            return false;
        }
        return true ;
    }
    private bool isAlp(char c)
    {
        if ((c >= 'A' && c <= 'Z') 
            || (c >= 'a' && c <= 'z') 
            || (c >= '0' && c <= '9'))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

//Java
class Solution {
    public boolean isPalindrome(String s) {
        if(s==null){
            return false;
        }
        int left=0, right=s.length()-1;
        while(left<right){
            if(!isAlp(s.charAt(left))){
                left++;
                continue;
            }
            if(!isAlp(s.charAt(right))){
                right--;
                continue;
            }
            if(Character.toLowerCase(s.charAt(left))==Character.toLowerCase(s.charAt(right))){
                left++;
                right--;
                continue;
            }
            return false;
        }
        return true;
    }
    public boolean isAlp(char c){
        if((c>='A'&&c<='Z')||(c>='a'&&c<='z')||(c>='0'&&c<='9')){
            return true;
        }
        else{
            return false;
        }
    }
}